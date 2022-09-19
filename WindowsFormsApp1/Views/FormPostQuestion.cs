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
    public partial class FormPostQuestion : Form
    {
        public FormPostQuestion()
        {
            InitializeComponent();
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewsUtils.SwitchForms(this, new FormHome());
        }

        private void post_btn(object sender, EventArgs e)
        {
            if(ViewsUtils.EmptyInputs(txtTitle, txtBody, txtTag))
            {
                MessageBox.Show("Any of the enteries can't be empty", "Enteries empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = txtTitle.Text, body = txtBody.Text, tag = txtTag.Text;

            ControllerPostQuestion c = new ControllerPostQuestion();
            bool posted =  c.PostQuestion(UserHome.User.Id, title, body, tag);

            if (posted)
            {
                MessageBox.Show("Your question in posted successfully", "Post question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewsUtils.SwitchForms(this, new FormHome());

            }
            else
            {
                MessageBox.Show("Couldn't post your question. Please try again later",
                    "Post question",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
