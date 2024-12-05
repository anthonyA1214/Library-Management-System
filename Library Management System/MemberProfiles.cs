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
    public partial class MemberProfiles : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        int memberid;

        public MemberProfiles()
        {
            InitializeComponent();
        }

        private void loadMemberTable()
        {
            string query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewImageColumn viewactivityImgCol = new DataGridViewImageColumn
            {
                Name = "viewactivity",
                HeaderText = string.Empty,
                Image = Properties.Resources.browseactivity,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            if (dgvMember.Columns["viewactivity"] == null)
            {
                dgvMember.Columns.Add(viewactivityImgCol);
            }
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void ViewMemberRecords()
        {
            string query1 = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date > tbl_issue.due_date THEN 'Overdue' ELSE 'On Time' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.member_id = @memberid;";
            string query2 = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.status AS [Loan Status], 'Not Returned' AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.member_id = @memberid AND tbl_issue.return_date IS NULL;";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd1.Parameters.AddWithValue("@memberid", memberid);
            cmd2.Parameters.AddWithValue("@memberid", memberid);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            da1.Fill(dt1);
            da2.Fill(dt2);

            dgvIssue1.DataSource = dt1;
            dgvIssue2.DataSource = dt2;

            dgvIssue1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIssue2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvIssue1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue1.ColumnHeadersDefaultCellStyle.BackColor;
            dgvIssue1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue1.ColumnHeadersDefaultCellStyle.ForeColor;
            dgvIssue2.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue2.ColumnHeadersDefaultCellStyle.BackColor;
            dgvIssue2.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue2.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void MemberProfiles_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
            cbSearchBy.Text = "Name";
            loadMemberTable();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMember.Columns["viewactivity"].Index)
            {
                tableLayoutPanel1.ColumnStyles[1].Width = 50;
                memberid = int.Parse(dgvMember.Rows[e.RowIndex].Cells["Member ID"].Value.ToString());
                ViewMemberRecords();
            }
        }

        private void dgvMember_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvMember.Columns[e.ColumnIndex].Name == "viewactivity")
            {
                e.ToolTipText = "View Activity";
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0";
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadMemberTable(); return;
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
                query += " AND member_id = @search";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy.Text == "Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "ID")
            {              
                cmd.Parameters.AddWithValue("@search", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
        }
    }
}
