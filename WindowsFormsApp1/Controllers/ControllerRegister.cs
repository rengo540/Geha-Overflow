using System;
using System.Collections.Generic;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace GehaOverFlow.Controllers
{
    class ControllerRegister
    {
        OracleConnection con;

        public ControllerRegister()
        {
            con = new OracleConnection(Utils.ORDB);
        }

        public bool Register(string username, string password)
        {
            con.Open();
            var cmd = new OracleCommand();
            cmd.Connection = con;

            try
            {
                cmd.CommandText = "INSERT INTO USERINFO (username, password, rep_points, is_admin) VALUES (:username, :password, 0, 0)";
                cmd.Parameters.Add("username", username);
                cmd.Parameters.Add("password", password);

                 cmd.ExecuteNonQuery();
                
                con.Close();

                return true;
            }
            catch (Exception)
            {
                con.Close();

                return false;
            }
        }
    }
}
