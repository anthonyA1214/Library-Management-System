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
    public partial class ManageStaffs : Form
    {
        public ManageStaffs()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        int select, staffid, checkrow;

        private void clearTexts()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            tbEmail.Clear();
            tbContactNumber.Clear();
            cbRole.Text = string.Empty;
        }

        private void loadTable()
        {
            string query = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStaff.DataSource = dt;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn updateImgCol = new DataGridViewImageColumn
            {
                Name = "update",
                HeaderText = string.Empty,
                Image = Properties.Resources.edit,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            DataGridViewImageColumn deleteImgCol = new DataGridViewImageColumn
            {
                Name = "delete",
                HeaderText = string.Empty,
                Image = Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            if (dgvStaff.Columns["update"] == null)
            {
                dgvStaff.Columns.Add(updateImgCol);
            }
            if (dgvStaff.Columns["delete"] == null)
            {
                dgvStaff.Columns.Add(deleteImgCol);
            }
            dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvStaff.ColumnHeadersDefaultCellStyle.BackColor;
            dgvStaff.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
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
            string role = cbRole.Text;
            bool isApproved = true;  

            string query;

            try
            {
                Regex regex = new Regex(@"^09[\d]{9}$", RegexOptions.IgnoreCase);
                Match match = regex.Match(contactnumber);
                if (!match.Success)
                {
                    MessageBox.Show("Invalid contact number format. Please ensure the number starts with '09' and is 11 digits long (e.g., '09123456789').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbContactNumber.Focus();
                    return;
                }

                Regex regex2 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
                Match match2 = regex2.Match(email);
                if (!match2.Success)
                {
                    MessageBox.Show("Invalid email format. Please ensure the email includes an '@' symbol and a valid domain (e.g., 'example@domain.com').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                if (select == 2) 
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this staff?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No) return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand();

                switch (select)
                {
                    case 1:
                        query = "INSERT INTO tbl_staff (first_name, last_name, username, password, email, contact_number, role, IsApproved, IsDeleted) VALUES(@firstname, @lastname, @username, @password, @email, @contactnumber, @role, @isApproved, @isDeleted)";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@isApproved", isApproved);    
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Staff added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlSideMenu.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the staff.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 2:
                        query = "UPDATE tbl_staff SET first_name = @firstname, last_name = @lastname, password = @password, contact_number = @contactnumber, role = @role";

                        if(tbUsername.Text != dgvStaff.CurrentRow.Cells["Username"].Value.ToString())
                        {
                            query += ", username = @username";
                        }
                        if(tbEmail.Text != dgvStaff.CurrentRow.Cells["Email"].Value.ToString())
                        {
                            query += ", email = @email";
                        }

                        query += " WHERE staff_id = @staffid";
                        cmd.CommandText = query;
                        cmd.Connection = conn;

                        if (tbUsername.Text != dgvStaff.CurrentRow.Cells["Username"].Value.ToString())
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                        }
                        if (tbEmail.Text != dgvStaff.CurrentRow.Cells["Email"].Value.ToString())
                        {
                            cmd.Parameters.AddWithValue("@email", email);
                        }

                        cmd.Parameters.AddWithValue("@staffid", staffid);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                        cmd.Parameters.AddWithValue("@role", role);   
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlSideMenu.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the staff.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
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
                loadTable(); 
            }
        }

        private void dgvStaff_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvStaff.Columns[e.ColumnIndex].Name == "update")
            {
                e.ToolTipText = "Update";
            }
            if (dgvStaff.Columns[e.ColumnIndex].Name == "delete")
            {
                e.ToolTipText = "Delete";
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvStaff.Columns["update"].Index)
            {
                string query = "SELECT * FROM tbl_staff WHERE staff_id = @staffid";
                staffid = int.Parse(dgvStaff.Rows[e.RowIndex].Cells["Staff ID"].Value.ToString());
                select = 2;
                clearTexts();
                lblSideMenu.Text = "UPDATE STAFF";
                pnlSideMenu.Visible = true;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@staffid", staffid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                tbFirstName.Text = ds.Tables[0].Rows[0][1].ToString();
                tbLastName.Text = ds.Tables[0].Rows[0][2].ToString();
                tbUsername.Text = ds.Tables[0].Rows[0][3].ToString();
                tbPassword.Text = ds.Tables[0].Rows[0][4].ToString();
                tbEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                tbContactNumber.Text = ds.Tables[0].Rows[0][6].ToString();
                cbRole.Text = ds.Tables[0].Rows[0][7].ToString();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvStaff.Columns["delete"].Index)
            {
                string query = "UPDATE tbl_staff SET IsDeleted = 1 WHERE staff_id = @staffid";
                staffid = int.Parse(dgvStaff.Rows[e.RowIndex].Cells["Staff ID"].Value.ToString());               
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffid", staffid);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.No) return;

                    checkrow = cmd.ExecuteNonQuery();

                    if (checkrow > 0)
                    {
                        MessageBox.Show("Staff deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the staff.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 1";
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadTable(); return;
            }

            if (cbSearchBy.Text == "Name")
            {
                query += " AND CONCAT(first_name, ' ', last_name) LIKE @search";
            }
            else if (cbSearchBy.Text == "Username")
            {
                query += " AND username = @search";
            }
            else if (cbSearchBy.Text == "ID")
            {
                query += " AND staff_id = @search";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy.Text == "Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "Username")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            else if (cbSearchBy.Text == "ID")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStaff.DataSource = dt;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
        }

        private void ManageStaffs_Load(object sender, EventArgs e)
        {
            loadTable();
            select = 0;
            pnlSideMenu.Visible = false;
            cbSearchBy.Text = "Name";
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "ADD STAFF";
            select = 1;
            clearTexts();
            if (pnlSideMenu.Visible == false) pnlSideMenu.Visible = true; else pnlSideMenu.Visible = false;
        }
    }
}
