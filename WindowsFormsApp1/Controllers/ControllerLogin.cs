using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using GehaOverFlow.Models;

namespace GehaOverFlow.Controllers
{
    class ControllerLogin
    {
        OracleConnection con;

        public ControllerLogin()
        {
            con = new OracleConnection(Utils.ORDB);
        }

        public bool Login(string username, string password)
        {
            con.Open();
            var cmd = new OracleCommand();
            cmd.Connection = con;

            try
            {
                cmd.CommandText = "SELECT * from USERINFO WHERE username = :username and password = :password";
                cmd.Parameters.Add("username", username);
                cmd.Parameters.Add("password", password);

                var r = cmd.ExecuteReader();

                var userExists = r.Read();
                if (userExists)
                {
                    var is_admin = Convert.ToInt32(r["is_admin"]) == 0 ? false : true;
                    var user = new User()
                    {
                        Id = Convert.ToInt32(r["user_id"]),
                        Username = r["username"].ToString(),
                        Password = r["password"].ToString(),
                        Reputation = Convert.ToInt32(r["rep_points"]),
                        IsAdmin = is_admin
                    };

                    UserHome.User = user;
                }

                con.Close();

                return userExists;
            }
            catch (Exception)
            {
                con.Close();

                return false;
            }
        }
    }
}
