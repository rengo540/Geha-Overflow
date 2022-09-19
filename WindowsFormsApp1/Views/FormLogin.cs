using System;
using System.Windows.Forms;
using GehaOverFlow.Controllers;

namespace GehaOverFlow.Views
{
    public partial class FormLogin : Form
    {
        ControllerLogin controller;
        public FormLogin()
        {
            InitializeComponent();
            controller = new ControllerLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var formRegsister = new FormRegister();
            formRegsister.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ViewsUtils.EmptyInputs(txtUsername, txtPassword))
            {
                MessageBox.Show("Either username of password can't be empty", "Enteries empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUsername.Text.ToLower(), password = txtPassword.Text;

            bool userExists = controller.Login(username, password);

            if (userExists)
            {
                ViewsUtils.SwitchForms(this, new FormHome());
            }
            else
            {
                MessageBox.Show("Couldn't Login. Please check your credentials and try again",
                    "Login failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
