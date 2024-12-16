using DocumentFormat.OpenXml.Office2010.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        SqlConnection conn = dbConnection.GetConnection();

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
            else if (string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                MessageBox.Show("The Confirm Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbConfirmPassword.Focus();
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
            else if (tbUsername.Text.Length < 3 || tbUsername.Text.Length > 20)
            {
                MessageBox.Show("The Username must be between 3 and 20 characters long!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return;
            }
            else if (tbPassword.Text.Length < 8)
            {
                MessageBox.Show("The Password must be at least 8 characters long!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return;
            }
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return;
            }

            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string confirmpassword = tbConfirmPassword.Text;
            string email = tbEmail.Text;
            string contactnumber = tbContactNumber.Text;
            string query;
            try
            {
                Regex nameRegex = new Regex(@"^[a-zA-Z\s]+$", RegexOptions.IgnoreCase);
                Match matchFirstName = nameRegex.Match(firstname);
                if (!matchFirstName.Success)
                {
                    MessageBox.Show("First name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbFirstName.Focus();
                    return;
                }

                Match matchLastName = nameRegex.Match(lastname);
                if (!matchLastName.Success)
                {
                    MessageBox.Show("Last name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbLastName.Focus();
                    return;
                }

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
                Match match = regex.Match(email);
                if (!match.Success)
                {
                    MessageBox.Show("Invalid email format. Please ensure the email includes an '@' symbol and a valid domain (e.g., 'example@domain.com').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                Regex regex2 = new Regex(@"^09[\d]{9}$", RegexOptions.IgnoreCase);
                Match match2 = regex2.Match(contactnumber);
                if (!match2.Success)
                {
                    MessageBox.Show("Invalid contact number format. Please ensure the number starts with '09' and is 11 digits long (e.g., '09123456789').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbContactNumber.Focus();
                    return;
                }          

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
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was an error while submitting your account. Please try again later.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("The username or email already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                conn.Close();
            }                     
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            visibility1.Visible = false;
            visibility2.Visible = false;
            tbPassword.UseSystemPasswordChar = true; 
            tbConfirmPassword.UseSystemPasswordChar = true;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            visibility1.Visible = true;
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                visibility1.Visible = false;
            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            visibility2.Visible = true;
            if (string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                visibility2.Visible = false;
            }
        }

        private void visibility1_Click(object sender, EventArgs e)
        {
            if(tbPassword.UseSystemPasswordChar == true)
            {
                visibility1.Image = Properties.Resources.visibilityoff;
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                visibility1.Image = Properties.Resources.visibilityon;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void visibility2_Click(object sender, EventArgs e)
        {
            if (tbConfirmPassword.UseSystemPasswordChar == true)
            {
                visibility2.Image = Properties.Resources.visibilityoff;
                tbConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                visibility2.Image = Properties.Resources.visibilityon;
                tbConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }         
}
