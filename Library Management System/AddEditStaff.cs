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
    public partial class AddEditStaff : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        int select, staff_id;

        public AddEditStaff()
        {
            InitializeComponent();
        }

        private void clearTexts()
        {
            tbStaffID.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            cbRole.Text = string.Empty;
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbContactNumber.Clear();            
        }

        private void loadTable()
        {
            conn.Open();
            string query = "SELECT * from tbl_staff";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (select == 2 || select == 3)
                {
                    if (dgvBook.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                    {
                        staff_id = int.Parse(dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }

                    string query = "SELECT * from tbl_staff WHERE staff_id = "+staff_id+"";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    tbStaffID.Text = ds.Tables[0].Rows[0][0].ToString();
                    tbUsername.Text = ds.Tables[0].Rows[0][1].ToString();
                    tbPassword.Text = ds.Tables[0].Rows[0][2].ToString();
                    cbRole.Text = ds.Tables[0].Rows[0][3].ToString();
                    tbFirstName.Text = ds.Tables[0].Rows[0][4].ToString();
                    tbLastName.Text = ds.Tables[0].Rows[0][5].ToString();
                    tbEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                    tbContactNumber.Text = ds.Tables[0].Rows[0][7].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disableEdit()
        {
            tbUsername.ReadOnly = true;
            tbPassword.ReadOnly = true;
            cbRole.Enabled = false;
            tbFirstName.ReadOnly = true;
            tbLastName.ReadOnly = true;
            tbEmail.ReadOnly = true;
            tbContactNumber.ReadOnly = true;
        }

        private void enableEdit()
        {
            tbUsername.ReadOnly = false;
            tbPassword.ReadOnly = false;
            cbRole.Enabled = true;
            tbFirstName.ReadOnly = false;
            tbLastName.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbContactNumber.ReadOnly = false;
        }

        private void AddEditStaff_Load(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
            loadTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "ADD STAFF";
            select = 1;
            enableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "UPDATE STAFF";
            select = 2;
            enableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "DELETE STAFF";
            select = 3;
            disableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            select = 0;
            loadTable();
            clearTexts();
            enableEdit();
            pnlSideMenu.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cbRole.Text;
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string email = tbEmail.Text;
            string contactnumber = tbContactNumber.Text;
            string query;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                switch (select)
                {
                    case 1:
                        query = "INSERT into tbl_staff(username,password,role,first_name,last_name,email,contact_number) values(@username,@password,@role,@firstname,@lastname,@email,@contactnumber)";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                        cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        query = "UPDATE tbl_staff SET username = @username, password = @password, role = @role, first_name = @firstname, last_name = @lastname, email = @email, contact_number = @contactnumber WHERE staff_id = "+staff_id+"";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                        cmd.ExecuteNonQuery();
                        break;
                    case 3:
                        query = "DELETE from tbl_staff WHERE staff_id = "+staff_id+"";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                clearTexts();
                loadTable();
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
        }       
    }
}
