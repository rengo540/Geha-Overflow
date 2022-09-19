using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GehaOverFlow.Views;
using GehaOverFlow.Controllers;
using GehaOverFlow.Models;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;




namespace GehaOverFlow.Views
{



    public partial class FormQuestion : Form
    {

        Question question;
        ControllerQuestion controllerQuestion;
        DataTable dataTable;
        public FormQuestion()
        {
            InitializeComponent();
        }

        private void FormQuestion_Load(object sender, EventArgs e)
        {
            

            question = FormHome.ClickedQuestion;
            questionTitle.Text = question.Title;
            questionBody.Text = question.Body;
            questionUser.Text = question.Author.Username;

            controllerQuestion = new ControllerQuestion();
             dataTable = controllerQuestion.loadAnswers(question.Id);

            dataTable.Columns.Remove("ans_id");

            answersGridView.DataSource = dataTable;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            ViewsUtils.SwitchForms(this, new FormHome());

        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            controllerQuestion = new ControllerQuestion();
            string txt = ansTxt.Text;
            DateTime dateTime = DateTime.Now;
            User user = UserHome.User;
            if (user.Reputation > 10)
            {

                dataTable = controllerQuestion.insertAnswer(question.Id,user.Id, txt, 0, 0, dateTime);
                answersGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("you must have at least 10 reputation to answer");
            }

        }
    }
}
