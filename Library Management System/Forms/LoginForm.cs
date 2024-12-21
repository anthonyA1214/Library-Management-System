using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library_Management_System.Resources;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = dbConnection.GetConnection();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
            this.AcceptButton = btnLogin;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                lblIncorrect.Text = "Username and password is required.";
                lblIncorrect.Visible = true;
                return;
            }

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            AuthenticateUser auth = new AuthenticateUser();
            AuthenticateUserResult authResult = auth.authenticateUser(username, password);           
                 
            if (authResult.isSuccessful)
            {
                if (authResult.role == "admin")
                {
                    AdminForm adminForm = new AdminForm(username);
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    UserForm userForm = new UserForm(username);
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                lblIncorrect.Text = authResult.message;
                lblIncorrect.Visible = true;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
        }

        private void lblLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            cbShowPassword.Checked = false;
            SignupForm signup = new SignupForm();
            signup.TopLevel = false;
            signup.Dock = DockStyle.Fill;
            signup.FormBorderStyle = FormBorderStyle.None;
            pnlContainer.Controls.Add(signup);
            signup.BringToFront();
            signup.Show();
        }
    }
}
