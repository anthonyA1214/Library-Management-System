using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddEditMember : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        int select, member_id;

        public AddEditMember()
        {
            InitializeComponent();
        }

        private void clearTexts()
        {
            tbMemberID.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbAddress.Clear();
            tbContactNumber.Clear();
            tbEmail.Clear();
            cbMembershipType.Text = string.Empty;
        }

        private void loadTable()
        {
            conn.Open();
            string query = "SELECT * from tbl_member";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && select == 2 || e.RowIndex >= 0 && select == 3)
                {
                    if (dgvMember.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                    {
                        member_id = int.Parse(dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }

                    string query = "SELECT * from tbl_member WHERE member_id = " + member_id + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    tbMemberID.Text = ds.Tables[0].Rows[0][0].ToString();
                    tbFirstName.Text = ds.Tables[0].Rows[0][1].ToString();
                    tbLastName.Text = ds.Tables[0].Rows[0][2].ToString();
                    tbAddress.Text = ds.Tables[0].Rows[0][3].ToString();
                    tbContactNumber.Text = ds.Tables[0].Rows[0][4].ToString();
                    tbEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                    cbMembershipType.Text = ds.Tables[0].Rows[0][6].ToString(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disableEdit()
        {
            tbFirstName.ReadOnly = true; 
            tbLastName.ReadOnly = true;
            tbAddress.ReadOnly = true;
            tbContactNumber.ReadOnly = true;
            tbEmail.ReadOnly = true;
            cbMembershipType.Enabled = false;
        }

        private void enableEdit()
        {
            tbFirstName.ReadOnly = false;
            tbLastName.ReadOnly = false;
            tbAddress.ReadOnly = false;
            tbContactNumber.ReadOnly = false;
            tbEmail.ReadOnly = false;
            cbMembershipType.Enabled = true;
        }

        private void AddEditMember_Load(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
            loadTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "ADD MEMBER";
            select = 1;
            enableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "UPDATE MEMBER";
            select = 2;
            enableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "DELETE MEMBER";
            select = 3;
            disableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            select = 0; member_id = 0;
            loadTable();
            clearTexts();
            enableEdit();
            pnlSideMenu.Visible = false;
          
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (select == 1 && tbFirstName.Text == "" && tbLastName.Text == "" && tbAddress.Text == "" && tbContactNumber.Text == "" && tbEmail.Text == "" && cbMembershipType.Text == "")
            {
                MessageBox.Show("All fields are required.", "Input error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (select == 2 && tbMemberID.Text == "")
            {
                MessageBox.Show("Please select a member to update.", "Selection required.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (select == 3 && tbMemberID.Text == "")
            {
                MessageBox.Show("Please select a member to delete.", "Selection required.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int memberid;
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string address = tbAddress.Text;
            string contactnumber = tbContactNumber.Text;
            string email = tbEmail.Text;
            string membershiptype = cbMembershipType.Text;
            string query;
            int checkrow;

            if (select == 2 || select == 3) { memberid = int.Parse(tbMemberID.Text); }

            else { memberid = 0; }
            try
            {
                if (select == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this member?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                        return;
                }
                if (select == 3)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                        return;
                }

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
                Match match = regex.Match(email);
                if (!match.Success)
                {
                    MessageBox.Show("Not valid email!.");
                    tbEmail.Focus();
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                switch (select)
                {
                    case 1:
                        query = "INSERT into tbl_member(first_name,last_name,address,contact_number,email,membership_type) values(@firstname,@lastname,@address,@contactnumber,@email,@membershiptype)";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@membershiptype", membershiptype);
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2:
                        query = "UPDATE tbl_member SET first_name = @firstname, last_name = @lastname, address = @address, contact_number = @contactnumber, email = @email, membership_type = @membershiptype WHERE member_id = @memberid";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@memberid", memberid);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@membershiptype", membershiptype);
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        query = "DELETE from tbl_member WHERE member_id = @memberid";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@memberid", memberid);
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            member_id = 0;
        }
    }
}
