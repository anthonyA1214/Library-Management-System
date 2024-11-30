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
    public partial class CurrentLoansOverview : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        public CurrentLoansOverview()
        {
            InitializeComponent();
        }

        private void clearTexts()
        {
            tbMemberNameID.Clear();
            tbBookTitleID.Clear();
            cbLoanStatus.Text = "All";
            cbDateRange.Text = string.Empty;
        }

        string query = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date > tbl_issue.due_date THEN 'Overdue' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Not Returned' END AS [Return Status] from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE 1=1";

        private void loadTable()
        {          
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIssue.DataSource = dt;
            dgvIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CurrentLoansOverview_Load(object sender, EventArgs e)
        {
            pnlCustomRange.Visible = false;
            loadTable();
            clearTexts();
            cbLoanStatus.Text = "All";
        }

        private void cbDateRange_TextChanged(object sender, EventArgs e)
        {
            if (cbDateRange.Text == "Custom Range")
            {
                pnlCustomRange.Visible = true;
            }
            else
            {
                pnlCustomRange.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTexts();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string name = tbMemberNameID.Text;
            string title = tbBookTitleID.Text;
            string status = cbLoanStatus.Text;
            int id;
            string filterQuery = query;
            string startDate = dtpStartDate.Value.ToString("MM/dd/yyyy");
            string endDate = dtpEndDate.Value.ToString("MM/dd/yyyy");

            if (string.IsNullOrEmpty(tbMemberNameID.Text) && string.IsNullOrEmpty(tbBookTitleID.Text) && string.IsNullOrEmpty(cbDateRange.Text) && cbLoanStatus.Text == "All" && cbDateRange.Text == "All")
            {
                loadTable();
                return;
            }

            //Member Name or ID Filter
            if (int.TryParse(tbMemberNameID.Text, out id))
            {
                filterQuery += " AND tbl_issue.member_id = @nameid";
            }
            else if (!string.IsNullOrEmpty(tbMemberNameID.Text))
            {
                filterQuery += " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @nameid";
            }
            //Book Title or ID Filter
            if (int.TryParse(tbBookTitleID.Text, out id))
            {
                filterQuery += " AND tbl_issue.book_id = @titleid";
            }
            else if (!string.IsNullOrEmpty(tbBookTitleID.Text))
            {
                filterQuery += " AND tbl_book.title LIKE @titleid";
            }
            //Loan Status Filter
            if (cbLoanStatus.Text != "All")
            {
                filterQuery += " AND tbl_issue.status = @status";
            }
            //Date Range Filter
            if (cbDateRange.Text != "All")
            {
                if (cbDateRange.Text == "Last 7 Days")
                {
                    filterQuery += " AND tbl_issue.issue_date >= DATEADD(day, -7, GETDATE())";
                }
                else if (cbDateRange.Text == "This Month")
                {
                    filterQuery += " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE()) AND MONTH(tbl_issue.due_date) = MONTH(GETDATE())";
                }
                else if (cbDateRange.Text == "This Year")
                {
                    filterQuery += " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE())";
                }
                else if (cbDateRange.Text == "Custom Range")
                {
                    filterQuery += " AND tbl_issue.issue_date BETWEEN @startDate AND @endDate";
                }
            }

            SqlCommand cmd = new SqlCommand(filterQuery, conn);
            //Member Name or ID 
            if (int.TryParse(tbMemberNameID.Text, out id))
            {
                cmd.Parameters.AddWithValue("@nameid", id);
            }
            else if (!string.IsNullOrEmpty(tbMemberNameID.Text))
            {
                cmd.Parameters.AddWithValue("@nameid", "%" + name + "%");
            }
            //Book Title or ID
            if (int.TryParse(tbBookTitleID.Text, out id))
            {
                cmd.Parameters.AddWithValue("@titleid", id);
            }
            else if (!string.IsNullOrEmpty(tbBookTitleID.Text))
            {
                cmd.Parameters.AddWithValue("@titleid", "%" + title + "%");
            }
            //Loan Status
            if (cbLoanStatus.Text != "All")
            {
                cmd.Parameters.AddWithValue("@status", status);
            }
            //Custom Range
            if (cbDateRange.Text != "All")
            {
                if (cbDateRange.Text == "Custom Range")
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                }
            }
 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIssue.DataSource = dt;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCurrentLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
