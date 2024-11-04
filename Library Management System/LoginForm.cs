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

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "Username" ||tbPassword.Text == "Password")
            {
                lblIncorrect.Text = "Username and password is required.";
                lblIncorrect.Visible = true;
                return;
            }

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            conn.Open();
            string query = "SELECT role from tbl_user WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            string role = (string)cmd.ExecuteScalar();

            try
            {            
                if(role != null)
                {
                    if(role == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    lblIncorrect.Text = "Incorrect username or password.";
                    lblIncorrect.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }           
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if(tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.White;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
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
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Silver;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if(tbPassword.Text == "")
            {
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
;            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else if(tbPassword.Text != "Password")
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
    }
}
