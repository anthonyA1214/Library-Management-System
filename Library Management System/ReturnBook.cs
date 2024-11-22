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

        private void btnFindDetails_Click(object sender, EventArgs e)
        {                   
            string bookid = tbBookID.Text;
            string memberid = tbMemberID.Text;
            string issueid = tbIssueID.Text;
            string findQuery = "SELECT tbl_issue.issue_id, tbl_book.title, tbl_member.first_name, tbl_member.last_name, tbl_issue.issue_date, tbl_issue.due_date, tbl_book.book_id, tbl_member.member_id from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE status = 'Issued'";

            try
            {
                if (!string.IsNullOrEmpty(tbIssueID.Text))
                {
                    findQuery += " AND issue_id = @issueid";
                }

                else if (!string.IsNullOrEmpty(tbBookID.Text) && !string.IsNullOrEmpty(tbMemberID.Text))
                {
                    findQuery += " AND tbl_issue.book_id = @bookid AND tbl_issue.member_id = @memberid";
                }

                else
                {
                    MessageBox.Show("Please provide Issue ID or both Book ID and Member ID.", "Input required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand findCmd = new SqlCommand(findQuery, conn);

                if (!string.IsNullOrEmpty(tbIssueID.Text))
                {
                    findCmd.Parameters.AddWithValue("@issueid", issueid);
                }

                else if (!string.IsNullOrEmpty(tbBookID.Text) && !string.IsNullOrEmpty(tbMemberID.Text))
                {
                    findCmd.Parameters.AddWithValue("@bookid", bookid);
                    findCmd.Parameters.AddWithValue("@memberid", memberid);
                }

                SqlDataAdapter da = new SqlDataAdapter(findCmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No record found matching the given id details.", "No record found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                lblIssueID.Text = ds.Tables[0].Rows[0][0].ToString();
                lblBookTitle.Text = ds.Tables[0].Rows[0][1].ToString();
                lblMemberName.Text = ds.Tables[0].Rows[0][2].ToString() + " " + ds.Tables[0].Rows[0][3].ToString();
                DateTime issueDate = Convert.ToDateTime(ds.Tables[0].Rows[0][4].ToString());
                DateTime dueDate = Convert.ToDateTime(ds.Tables[0].Rows[0][5].ToString());
                lblIssueDate.Text = issueDate.ToString("MM/dd/yyyy");
                lblDueDate.Text = dueDate.ToString("MM/dd/yyyy");
                if (!string.IsNullOrEmpty(tbIssueID.Text))
                {
                    tbBookID.Text = ds.Tables[0].Rows[0][6].ToString();
                    tbMemberID.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else if (!string.IsNullOrEmpty(tbBookID.Text) && !string.IsNullOrEmpty(tbMemberID.Text))
                {
                    tbIssueID.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbIssueID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIssueID.Text))
            {
                tbBookID.Enabled = false;
                tbMemberID.Enabled = false;            
            }
            else
            {
                tbBookID.Enabled = true;
                tbMemberID.Enabled = true;
                clearTexts();
                tbBookID.Clear();
                tbMemberID.Clear();
            }
        }

        private void tbBookID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBookID.Text))
            {
                tbIssueID.Enabled = false;                
            }
            else
            {
                tbIssueID.Enabled = true;
                clearTexts();
                tbIssueID.Clear();
            }              
        }

        private void tbMemberID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMemberID.Text))
            {
                tbIssueID.Enabled = false;
            }
            else
            {
                tbIssueID.Enabled = true;
                clearTexts();
                tbIssueID.Clear();
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            string issueid = lblIssueID.Text;
            string returndate = DateTime.Now.ToShortDateString();
            string bookid = tbBookID.Text;
            try
            {
                conn.Open();
                string returnQuery = "UPDATE tbl_issue SET return_date = @returndate, status = 'Returned' WHERE issue_id = @issueid";
                SqlCommand returnCmd = new SqlCommand(returnQuery, conn);
                returnCmd.Parameters.AddWithValue("@returndate", returndate);
                returnCmd.Parameters.AddWithValue("@issueid", issueid);
                int checkreturn = returnCmd.ExecuteNonQuery();

                string updateQuery = "UPDATE tbl_book SET copies_available = copies_available + 1 WHERE book_id = @bookid";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@bookid", bookid);
                int checkupdate = updateCmd.ExecuteNonQuery();

                if(checkreturn > 0 && checkupdate > 0)
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
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            clearTexts();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
