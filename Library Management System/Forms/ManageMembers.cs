using Library_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ManageMembers : Form
    {
        SqlConnection conn = dbConnection.GetConnection();
        int select, memberid, checkrow;

        private string userRole;

        public ManageMembers(string userrole)
        {
            InitializeComponent();
            userRole = userrole;
        }


        private void HandleLogin(string userRole)
        {
            if (userRole == "Staff")
            {
                dgvMember.Columns["delete"].Visible = false;
            }
            else if (userRole == "Admin")
            {
                dgvMember.Columns["delete"].Visible = true;
            }
        }

        private void clearTexts()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbAddress.Clear();
            tbContactNumber.Clear();
            tbEmail.Clear();
            cbMembershipType.Text = "Child";
        }

        private void loadTable()
        {
            string query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (dgvMember.Columns["update"] == null)
            {
                dgvMember.Columns.Add(updateImgCol);
            }
            if (dgvMember.Columns["delete"] == null)
            {
                dgvMember.Columns.Add(deleteImgCol);
            }
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor;
            HandleLogin(userRole);
        }

        private void ManageMembers_Load(object sender, EventArgs e)
        {
            loadTable();
            pnlSideMenu.Visible = false;
            cbSearchBy.Text = "Name";           
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "ADD MEMBER";
            select = 1;
            clearTexts();
            cbMembershipType.Text = "Child";
            if (pnlSideMenu.Visible == false) pnlSideMenu.Visible = true; else pnlSideMenu.Visible = false;
            
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMember.Columns["update"].Index)
            {
                string query = "SELECT * from tbl_member WHERE member_id = @memberid";
                memberid = int.Parse(dgvMember.Rows[e.RowIndex].Cells["Member ID"].Value.ToString());
                select = 2;
                clearTexts();
                lblSideMenu.Text = "UPDATE MEMBER";
                pnlSideMenu.Visible = true;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@memberid", memberid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                tbFirstName.Text = ds.Tables[0].Rows[0][1].ToString();
                tbLastName.Text = ds.Tables[0].Rows[0][2].ToString();
                numAge.Value = decimal.Parse(ds.Tables[0].Rows[0][3].ToString());
                tbAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                tbContactNumber.Text = ds.Tables[0].Rows[0][5].ToString();
                tbEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                cbMembershipType.Text = ds.Tables[0].Rows[0][7].ToString();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMember.Columns["delete"].Index)
            {
                string query = "UPDATE tbl_member SET IsDeleted = 1 WHERE member_id = @memberid";
                memberid = int.Parse(dgvMember.Rows[e.RowIndex].Cells["Member ID"].Value.ToString());
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@memberid", memberid);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No) return;
                    checkrow = cmd.ExecuteNonQuery();
                    if (checkrow > 0)
                    {
                        MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); clearTexts(); loadTable();
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0";
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadTable(); return;
            } 

            if (cbSearchBy.Text == "Name")
            {
                query += " AND CONCAT(first_name, ' ', last_name) LIKE @search";
            }
            else if (cbSearchBy.Text == "ID")
            {
                if (!int.TryParse(search, out int id))
                {
                    return;
                }
                query += " AND member_id LIKE @search";
            }

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
        }

        private void dgvMember_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvMember.Columns[e.ColumnIndex].Name == "update")
            {
                e.ToolTipText = "Update";
            }
            if (dgvMember.Columns[e.ColumnIndex].Name == "delete")
            {
                e.ToolTipText = "Delete";
            }
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            clearTexts();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                MessageBox.Show("First Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFirstName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Last Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbLastName.Focus();
                return;
            }
            else if (numAge.Value == 0)
            {
                MessageBox.Show("Age field cannot be zero!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAge.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("Address field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbAddress.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbContactNumber.Text))
            {
                MessageBox.Show("Contact Number field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbContactNumber.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return;
            }
           
            Member member = new Member(memberid, tbFirstName.Text, tbLastName.Text, int.Parse(numAge.Text), tbAddress.Text, tbContactNumber.Text, tbEmail.Text, cbMembershipType.Text);
            manageMembers memberManager = new manageMembers();

            try
            {
                Regex nameRegex = new Regex(@"^[a-zA-Z\s]+$", RegexOptions.IgnoreCase);
                Match matchFirstName = nameRegex.Match(tbFirstName.Text);
                if (!matchFirstName.Success)
                {
                    MessageBox.Show("First name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbFirstName.Focus();
                    return;
                }

                Match matchLastName = nameRegex.Match(tbLastName.Text);
                if (!matchLastName.Success)
                {
                    MessageBox.Show("Last name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbLastName.Focus();
                    return;
                }

                Regex regex = new Regex(@"^09[\d]{9}$", RegexOptions.IgnoreCase);
                Match match = regex.Match(tbContactNumber.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Invalid contact number format. Please ensure the number starts with '09' and is 11 digits long (e.g., '09123456789').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbContactNumber.Focus();
                    return;
                }

                Regex regex2 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
                Match match2 = regex2.Match(tbEmail.Text);
                if (!match2.Success)
                {
                    MessageBox.Show("Invalid email format. Please ensure the email includes an '@' symbol and a valid domain (e.g., 'example@domain.com').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Focus();
                    return;
                }

                if (select == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this member?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                        return;
                }

                conn.Open();
                bool result;
                switch (select)
                {
                    case 1:
                        result = memberManager.AddMember(member);
                        if (result)
                        {
                            MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlSideMenu.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2:
                        result = memberManager.UpdateMember(member);
                        if (result)
                        {
                            MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlSideMenu.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;                   
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) 
                {
                    MessageBox.Show("The email address already exists.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
               
    }
}
