using GehaOverFlow.Controllers;
using GehaOverFlow.Models;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Windows.Forms;
namespace GehaOverFlow.Views
{
    public partial class FormRegister : Form
    {
        ControllerRegister controller;
        public FormRegister()
        {
            InitializeComponent();

            controller = new ControllerRegister();
        }

        private void btnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

            if (ViewsUtils.EmptyInputs(txtUsername, txtPassword))
            {
                MessageBox.Show("Either username of password can't be empty", "Enteries empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkboxTerms.Checked)
            {
                MessageBox.Show("Terms and conditions must be agreed upon", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUsername.Text.ToLower(), password = txtPassword.Text;

            bool registered = controller.Register(txtUsername.Text, txtPassword.Text);
            if (registered)
            {
                MessageBox.Show("Registeration successful.", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();

            }
            else
            {
                MessageBox.Show("Couldn't register. Please check your credentials and try again", 
                    "Registeration failed", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}
