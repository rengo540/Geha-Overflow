using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using GehaOverFlow.Models;


namespace GehaOverFlow.Controllers
{
    public class ControllerQuestion
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet dataSet;
        public ControllerQuestion()
        {            

        }

        public DataTable loadAnswers(int questionId) {

            string cmd = "select * from answers where q_id = :questId ";

            adapter=new OracleDataAdapter(cmd,Utils.ORDB);
            adapter.SelectCommand.Parameters.Add("questId", questionId);

            dataSet = new DataSet();
            adapter.Fill(dataSet);
           return dataSet.Tables[0];

        
        }


        public DataTable insertAnswer(int questId, int userId, string txt, int downVote, int upVote, DateTime dateTime)
        {
            DataTable dt=loadAnswers(questId);
            dt.Columns.Remove("ans_id");
            DataRow dr = dt.NewRow();

            dr[0] = questId;
            dr[1] = userId;
            dr[2] = txt;
            dr[3] = downVote;
            dr[4] = upVote;
            dr[5] = dateTime;

            dt.Rows.Add(dr);
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(dt);

            return dt;
        }
    }
}
