using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using GehaOverFlow.Models;

namespace GehaOverFlow.Controllers
{
    public class ControllerHome
    {
        OracleConnection conn;
        public ControllerHome()
        {
            conn = new OracleConnection(Utils.ORDB);
            conn.Open();
        }
        public List<Question> LoadQuestions()
        {
            var questions = new List<Question>();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            //  cmd.CommandText = "select * from Questions";

            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetQuestions";
            cmd.Parameters.Add("questions", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Question question = new Question() { };
                var user = new User() { Id = int.Parse(dr[2].ToString()), Username = userNameForId(int.Parse(dr[2].ToString())) };

                questions.Add(new Question()
                {
                    Id = int.Parse(dr[0].ToString()),
                    Title = dr[1].ToString(),
                    Author = user,
                    Upvotes = int.Parse(dr[3].ToString()),
                    Body = dr[4].ToString(),
                    Downvotes = int.Parse(dr[5].ToString()),
                  //  PostDate = Convert.ToDateTime(dr[6]),
                    Category = dr[7].ToString()


                }) ; 
            }
            dr.Close();

            return questions;
        }

       


        public string userNameForId (int id)
        {
            
            //throw new NotImplementedException();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select username  from userinfo  where user_id = :id  ";
           // cmd1.CommandText = "GetUserName";
            cmd1.CommandType = CommandType.Text;

            cmd1.Parameters.Add("id",id);
           // cmd1.Parameters.Add("user", OracleDbType.Varchar2 , ParameterDirection.Output);
            //cmd.ExecuteNonQuery();
            OracleDataReader dr1 = cmd1.ExecuteReader();


            // return cmd.Parameters["user"].Value.ToString();
            string s = "";
            while (dr1.Read())
            {
                s = dr1[0].ToString();
            }
            return s;
        }
    }
}
