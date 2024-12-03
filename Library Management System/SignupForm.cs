using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        private void lblLinkBack2Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int checkrow;

            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                MessageBox.Show("The First Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFirstName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("The Last Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbLastName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("The Username field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("The Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("The Email field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbContactNumber.Text))
            {
                MessageBox.Show("The Contact Number field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbContactNumber.Focus();
                return;
            }

            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string contactnumber = tbContactNumber.Text;
            string query;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                query = "INSERT INTO tbl_staff (first_name, last_name, username, password, email, contact_number) VALUES(@firstname, @lastname, @username, @password, @email, @contactnumber)";
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@contactnumber", contactnumber);

                checkrow = cmd.ExecuteNonQuery();

                if (checkrow > 0)
                {
                    MessageBox.Show("Your account has been submitted successfully. Please wait for approval.", "Signup Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was an error while submitting your account. Please try again later.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                this.Close();
            }                     
        }
    }         
}
