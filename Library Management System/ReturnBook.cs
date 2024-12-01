using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        int issueid, bookid;

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void clearTexts()
        {
            lblIssueID.Text = string.Empty;
            lblBookTitle.Text = string.Empty;
            lblMemberName.Text = string.Empty;
            lblIssueDate.Text = string.Empty;
            lblDueDate.Text = string.Empty;
        }

        private void loadTable()
        {
            string query = "SELECT tbl_issue.issue_id as [Issue ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) as [Member Name], tbl_book.title as [Book Title] from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE status = 'Issued'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIssue.DataSource = dt;
            dgvIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIssueID.Text))
            {
                MessageBox.Show("Please select a record to return.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to return the book '{lblBookTitle.Text}' issued to '{lblMemberName.Text}'?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ( dialogResult == DialogResult.Yes)
            {
                string returndate = DateTime.Now.ToShortDateString();
                try
                {

                    conn.Open();
                    string returnQuery = "UPDATE tbl_issue SET return_date = @returndate, status = 'Returned' WHERE issue_id = @issueid";
                    SqlCommand returnCmd = new SqlCommand(returnQuery, conn);
                    returnCmd.Parameters.AddWithValue("@returndate", returndate);
                    returnCmd.Parameters.AddWithValue("@issueid", issueid);
                    int checkreturn = returnCmd.ExecuteNonQuery();

                    string updateQuery = "UPDATE tbl_book SET quantity = quantity + 1 WHERE book_id = @bookid";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@bookid", bookid);
                    int checkupdate = updateCmd.ExecuteNonQuery();

                    if (checkreturn > 0 && checkupdate > 0)
                    {
                        MessageBox.Show("Returned book successfully.\nInventory updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            clearTexts();
            loadTable();
            cbSearchBy.Text = "Member Name";
            dgvIssue.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue.ColumnHeadersDefaultCellStyle.BackColor;
            dgvIssue.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT tbl_issue.issue_id as [Issue ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) as [Member Name], tbl_book.title as [Book Title] from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE status = 'Issued'";
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadTable(); return;
            }

            if (cbSearchBy.Text == "Member Name")
            {
                query += " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search";
            }
            else if (cbSearchBy.Text == "Member ID")
            {
                if (!int.TryParse(tbSearch.Text, out int id))
                {
                    return;
                }
                query += " AND tbl_issue.member_id = @search";
            }
            else if (cbSearchBy.Text == "Issue ID")
            {
                if (!int.TryParse(tbSearch.Text, out int id))
                {
                    return;
                }
                query += " AND tbl_issue.issue_id = @search";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy.Text == "Member Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "Member ID" || cbSearchBy.Text == "Issue ID")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIssue.DataSource = dt;
        }

        private void dgvIssue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvIssue.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                try
                {
                    issueid = int.Parse(dgvIssue.Rows[e.RowIndex].Cells[0].Value.ToString());

                    string query = "SELECT tbl_issue.issue_id, tbl_issue.book_id, tbl_book.title, tbl_member.first_name, tbl_member.last_name, tbl_issue.issue_date, tbl_issue.due_date FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.issue_id = @issueid AND tbl_issue.status = 'Issued'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@issueid", issueid);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblIssueID.Text = reader["issue_id"].ToString();
                        lblBookTitle.Text = reader["title"].ToString();
                        lblMemberName.Text = $"{reader["first_name"]} {reader["last_name"]}";
                        lblIssueDate.Text = Convert.ToDateTime(reader["issue_date"]).ToString("MM/dd/yyyy");
                        lblDueDate.Text = Convert.ToDateTime(reader["due_date"]).ToString("MM/dd/yyyy");
                        bookid = int.Parse(reader["book_id"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}
