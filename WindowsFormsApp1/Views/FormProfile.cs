using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GehaOverFlow.Controllers;
using GehaOverFlow.Models;

namespace GehaOverFlow.Views
{
    public partial class FormProfile : Form
    {

        ControllerProfile controller;

        public FormProfile()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

            controller = new ControllerProfile();

            User user = new User();
            user = UserHome.User;
            lblUsername.Text = user.Username;
            lblReputation.Text = user.Reputation.ToString();
            lblAnswersCount.Text = controller.getMyAnswersCount(user.Id);
           
            
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "question title";
            dataGridView1.Columns[1].Name = "up vote";
            dataGridView1.Columns[2].Name = "down vote";
            dataGridView1.Columns[3].Name = "tags";



           

            var questions = controller.getMyQuestions(user.Id);

            lblQuestionsCount.Text = questions.Count.ToString();

            foreach (Question question in questions)
            {
                string[] row1 = new string[] {  question.Title, question.Upvotes.ToString(), question.Downvotes.ToString(), question.Category };

                dataGridView1.Rows.Add(row1);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ViewsUtils.SwitchForms(this, new FormHome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewsUtils.SwitchForms(this, new FormLogin());
        }

        private void crystalBtn_Click(object sender, EventArgs e)
        {
            ViewsUtils.SwitchForms(this, new FormCrystal());

        }
    }
}
