using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
                        member_id = int.Parse(dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            select = 0;
            loadTable();
            clearTexts();
            enableEdit();
            pnlSideMenu.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string address = tbAddress.Text;
            string contactnumber = tbContactNumber.Text;
            string email = tbEmail.Text;
            string membershiptype = cbMembershipType.Text;
            string query;
            try
            {
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
                        cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        query = "UPDATE tbl_member SET first_name = @firstname, last_name = @lastname, address = @address, contact_number = @contactnumber, email = @email, membership_type = @membershiptype";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@membershiptype", membershiptype);
                        cmd.ExecuteNonQuery();
                        break;
                    case 3:
                        query = "DELETE from tbl_member WHERE member_id = "+member_id+"";
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
