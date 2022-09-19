using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using GehaOverFlow.Models;

namespace GehaOverFlow.Controllers
{
    public class ControllerProfile
    {

        OracleConnection con;

        public ControllerProfile()
        {
            con = new OracleConnection(Utils.ORDB);
            con.Open();
        }

        public List<Question> getMyQuestions (int userId)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from questions where user_id = :UserId ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("UserId", userId);
            OracleDataReader dr = cmd.ExecuteReader();

            var questions = new List<Question>();

            while (dr.Read())
            {   
                var user = new User() { Id = userId };

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


                });

            }

            dr.Close();
            return questions;
        }



        public string getMyAnswersCount (int userId)
        {
            // throw new NotImplementedException();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "Answers_count";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("userId", userId);
            cmd.Parameters.Add("count", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            string count = cmd.Parameters["count"].Value.ToString();
            return count;
        }


    }
}
