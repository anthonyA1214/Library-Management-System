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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class ViewRecords : Form
    {
        public ViewRecords()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        private void loadTable()
        {
            string query = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date > tbl_issue.due_date THEN 'Overdue' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Not Returned' END AS [Return Status] from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE 1=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIssue.DataSource = dt;
            dgvIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewRecords_Load(object sender, EventArgs e)
        {
            pnlCustomRange.Visible = false;
            loadTable();
            cbLoanStatus.Text = "All";
            cbDateRange.Text = "All";
            cbSearchBy.Text = "Member Name";
        }

        private void searchFilter()
        {
            string searchQuery = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date > tbl_issue.due_date THEN 'Overdue' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Not Returned' END AS [Return Status] from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE 1=1";

            string search = tbSearch.Text;
            string status = cbLoanStatus.Text;
            string startDate = dtpStartDate.Value.ToString("MM/dd/yyyy");
            string endDate = dtpEndDate.Value.ToString("MM/dd/yyyy");

            if (string.IsNullOrEmpty(search))
            {
                if (cbLoanStatus.Text != "All")
                {
                    searchQuery += " AND tbl_issue.status = @status";
                }

                if (cbDateRange.Text != "All")
                {
                    if (cbDateRange.Text == "Last 7 Days")
                    {
                        searchQuery += " AND tbl_issue.issue_date >= DATEADD(day, -7, GETDATE())";
                    }
                    else if (cbDateRange.Text == "This Month")
                    {
                        searchQuery += " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE()) AND MONTH(tbl_issue.due_date) = MONTH(GETDATE())";
                    }
                    else if (cbDateRange.Text == "This Year")
                    {
                        searchQuery += " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE())";
                    }
                    else if (cbDateRange.Text == "Custom Range")
                    {
                        searchQuery += " AND tbl_issue.issue_date BETWEEN @startDate AND @endDate";
                    }
                }
            }

            if (cbSearchBy.Text == "Member Name")
            {
                searchQuery += " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search";
            }
            else if (cbSearchBy.Text == "Member ID")
            {
                if (!int.TryParse(search, out int id))
                {
                    return;
                }
                searchQuery += " AND tbl_issue.member_id = @search";
            }
            else if (cbSearchBy.Text == "Book Title")
            {
                searchQuery += " AND tbl_book.title LIKE @search";
            }
            else if (cbSearchBy.Text == "Book ID")
            {
                if (!int.TryParse(search, out int bookId))
                {
                    return;
                }
                searchQuery += " AND tbl_issue.book_id = @search";
            }

            if (cbLoanStatus.Text != "All")
            {
                searchQuery += " AND tbl_issue.status = @status";
            }

            if (cbDateRange.Text != "All")
            {
                if (cbDateRange.Text == "Last 7 Days")
                {
                    searchQuery += " AND tbl_issue.issue_date >= DATEADD(day, -7, GETDATE())";
                }
                else if (cbDateRange.Text == "This Month")
                {
                    searchQuery += " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE()) AND MONTH(tbl_issue.due_date) = MONTH(GETDATE())";
                }
                else if (cbDateRange.Text == "This Year")
                {
                    searchQuery += " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE())";
                }
                else if (cbDateRange.Text == "Custom Range")
                {
                    searchQuery += " AND tbl_issue.issue_date BETWEEN @startDate AND @endDate";
                }
            }

            SqlCommand cmd = new SqlCommand(searchQuery, conn);
            if (cbSearchBy.Text == "Member Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "Member ID")
            {
                if (!int.TryParse(search, out int id))
                {
                    return;
                }
                cmd.Parameters.AddWithValue("@search", search);
            }
            else if (cbSearchBy.Text == "Book Title")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "Book ID")
            {
                if (!int.TryParse(search, out int bookId))
                {
                    return;
                }
                cmd.Parameters.AddWithValue("@search", search);
            }
            
            if (cbLoanStatus.Text != "All")
            {
                cmd.Parameters.AddWithValue("@status", status);
            }
          
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void cbLoanStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void cbDateRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchFilter();
            if (cbDateRange.Text == "Custom Range")
            {
                pnlCustomRange.Visible = true;
            }
            else
            {
                pnlCustomRange.Visible = false;
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            searchFilter();
        }
    }
}
