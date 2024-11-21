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
    public partial class IssueBook : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        public IssueBook()
        {
            InitializeComponent();
        }

        int book_id, member_id;

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvBook.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                {
                    book_id = int.Parse(dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                string query = "SELECT * from tbl_book WHERE book_id = "+ book_id +"";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                tbBookID.Text = ds.Tables[0].Rows[0][0].ToString();
                tbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
                tbAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                tbISBN.Text = ds.Tables[0].Rows[0][3].ToString();
                tbGenre.Text = ds.Tables[0].Rows[0][4].ToString();
                int publicationYear = int.Parse(ds.Tables[0].Rows[0][5].ToString());
                dtpPublicationYear.Value = new DateTime(publicationYear, 1, 1);
                tbCopiesAvailable.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
                tbMembershipType.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string search1 = tbSearchBookIDTitle.Text;
            int bookID;
            string query = "SELECT * from tbl_book WHERE 1=1";
            if (int.TryParse(tbSearchBookIDTitle.Text, out bookID))
            {
                query += " AND book_id = @search1";
            }
            else if (!string.IsNullOrEmpty(tbSearchBookIDTitle.Text))
            {
                query += " AND title LIKE @search1";
            }
                SqlCommand cmd = new SqlCommand(query, conn);
            if(int.TryParse(tbSearchBookIDTitle.Text, out bookID))
            {      
                cmd.Parameters.AddWithValue("@search1", bookID);
            }
            else if (!string.IsNullOrEmpty(tbSearchBookIDTitle.Text))
            {               
                cmd.Parameters.AddWithValue("@search1", "%" + search1 + "%");
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void IssueBook_Click(object sender, EventArgs e)
        {
            string bookid = tbBookID.Text;
            string memberid = tbMemberID.Text;
            DateTime issuedate = dtpIssueDate.Value;
            DateTime duedate = dtpDueDate.Value;

            if(string.IsNullOrEmpty(tbBookID.Text) && string.IsNullOrEmpty(tbMemberID.Text))
            {
                MessageBox.Show("Please select both Book ID and Member ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                string checkQuery = "SELECT copies_available from tbl_book WHERE book_id = @bookid";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@bookid", bookid);
                int copiesAvailable = Convert.ToInt32(checkCmd.ExecuteScalar());

                if(copiesAvailable <= 0)
                {
                    MessageBox.Show("Insufficient copies.", "Not enough copies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string issueQuery = "INSERT into tbl_issue (book_id, member_id, issue_date, due_date, status) VALUES(@bookid, @memberid, @issuedate, @duedate, 'Issued')";
                SqlCommand issueCmd = new SqlCommand(issueQuery, conn);
                issueCmd.Parameters.AddWithValue("@bookid", bookid);
                issueCmd.Parameters.AddWithValue("@memberid", memberid);
                issueCmd.Parameters.AddWithValue("@issuedate", issuedate);
                issueCmd.Parameters.AddWithValue("@duedate", duedate);
                issueCmd.ExecuteNonQuery();

                string updateQuery = "UPDATE tbl_book SET copies_available = copies_available - 1 WHERE book_id = @bookid";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@bookid", bookid);
                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string search2 = tbSearchMemberIDTitle.Text;
            int memberID;
            string query = "SELECT * from tbl_member WHERE 1=1";
            if(int.TryParse(tbSearchMemberIDTitle.Text, out memberID))
            {
                query += " AND member_id = @search2";
            }
            else if (!string.IsNullOrEmpty(tbSearchMemberIDTitle.Text))
            {
                query += " AND (first_name LIKE @search2 OR last_name LIKE @search2)";
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            if (int.TryParse(tbSearchMemberIDTitle.Text, out memberID))
            {   
                cmd.Parameters.AddWithValue("@search2", memberID);
            }
            else if (!string.IsNullOrEmpty(tbSearchMemberIDTitle.Text))
            {
                cmd.Parameters.AddWithValue("search2", "%" + search2 + "%");
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;

        }    
    }
}
