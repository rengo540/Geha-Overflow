using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using GehaOverFlow.Models;

namespace GehaOverFlow.Controllers
{
    public class ControllerPostQuestion
    {
        OracleConnection conn;
        DateTime POST_DATE;
        public ControllerPostQuestion()
        {
            conn = new OracleConnection(Utils.ORDB);
            conn.Open();
            POST_DATE = DateTime.Now;
        }

        public bool PostQuestion(int USER_ID, string Q_TITLE, string TXT, string CATEGORY_NAME)
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            var sqlNow = DateTime.Now.ToString("dd-MMM-yy");

            try
            {
                cmd.CommandText = "INSERT into QUESTIONS (category_name, downvotes, q_title, txt, upvotes, user_id, post_date)"+
                    "values(:category_name, 0, :title, :text, 0, :userId, :post_date)";

                cmd.Parameters.Add("category_name", CATEGORY_NAME);
                cmd.Parameters.Add("title", Q_TITLE);
                cmd.Parameters.Add("text", TXT);
                cmd.Parameters.Add("userId", USER_ID);
                cmd.Parameters.Add("post_date", sqlNow);

                cmd.ExecuteNonQuery();
                
                conn.Close();

                return true;
            }
            catch (Exception ex) {

                return false;
            }

        }
    
    }
}
