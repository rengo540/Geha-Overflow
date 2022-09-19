using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GehaOverFlow.Controllers;
using GehaOverFlow.Models;

namespace GehaOverFlow.Views
{
    public partial class FormHome : Form
    {
        ControllerHome controller;
        List<Question> questions;
        public static Question ClickedQuestion =new Question();
        public FormHome()
        {
            InitializeComponent();
            controller = new ControllerHome();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            ViewsUtils.SwitchForms(this, new FormPostQuestion());
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            gridQuestions.ColumnCount = 5;

            gridQuestions.Columns[0].Name = "user name";
            gridQuestions.Columns[1].Name = "question title";
            gridQuestions.Columns[2].Name = "up vote";
            gridQuestions.Columns[3].Name = "down vote";
            gridQuestions.Columns[4].Name = "tags";



            controller = new ControllerHome();
           
            questions = controller.LoadQuestions();


            foreach (Question question in questions)
            {
                string[] row1 = new string[] { question.Author.Username.ToString(), question.Title ,question.Upvotes.ToString(),question.Downvotes.ToString(),question.Category};

                gridQuestions.Rows.Add(row1);
            }

        }

        private void gridQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridQuestions_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("suiiii");
            int row = e.RowIndex;
            ClickedQuestion = questions[row];

            ViewsUtils.SwitchForms(this, new FormQuestion());

        }

		private void profileBtn_Click(object sender, EventArgs e)
		{
            ViewsUtils.SwitchForms(this, new FormProfile());

        }
    }
}
