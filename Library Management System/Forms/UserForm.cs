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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management_System
{
    public partial class UserForm : Form
    {
        private string Username;
        public UserForm(string username)
        {
            InitializeComponent();
            Username = username;
        }

        SqlConnection conn = dbConnection.GetConnection();

        private void hideDashboard()
        {
            pnlTitle.Visible = false;
            tlp1.Visible = false;
            tlp2.Visible = false;
            tlp3.Visible = false;
            tlp4.Visible = false;
        }

        private void showDashboard(object sender, FormClosedEventArgs e)
        {
            loadTable();
            pnlTitle.Visible = true;
            tlp1.Visible = true;
            tlp2.Visible = true;
            tlp3.Visible = true;
            tlp4.Visible = true;
        }

        private void hideSubMenu()
        {
            pnlBooksSubMenu.Visible = false;
            pnlMembersSubMenu.Visible = false;
            pnlBorrowReturnSubMenu.Visible = false;
            pnlReportsSubMenu.Visible = false;
            pnlSettingsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void loadCount()
        {
            string query1 = "SELECT COUNT(*) from tbl_book";
            string query2 = "SELECT COUNT(*) from tbl_member";
            string query3 = "SELECT COUNT(*) from tbl_issue WHERE status = 'Issued'";
            string query4 = "SELECT COUNT(*) FROM tbl_issue WHERE return_date IS NULL AND due_date < GETDATE()";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            SqlCommand cmd4 = new SqlCommand(query4, conn);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);

            DataSet ds = new DataSet();

            da1.Fill(ds, "BookCount");
            da2.Fill(ds, "MemberCount");
            da3.Fill(ds, "IssuedCount");
            da4.Fill(ds, "OverdueCount");

            lblCountBook.Text = ds.Tables["BookCount"].Rows[0][0].ToString();
            lblCountMember.Text = ds.Tables["MemberCount"].Rows[0][0].ToString();
            lblIssuedBook.Text = ds.Tables["IssuedCount"].Rows[0][0].ToString();
            lblOverdueBook.Text = ds.Tables["OverdueCount"].Rows[0][0].ToString();
        }

        private void loadTable()
        {
            string issueQuery = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.status = 'Issued'"; dgvIssuedBook.DataSource = loadData(issueQuery);
            dgvIssuedBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string overdueQuery = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.status AS [Loan Status], 'Overdue' AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE()";
            dgvOverdueBook.DataSource = loadData(overdueQuery);
            dgvOverdueBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string memberQuery = "SELECT TOP 5 member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0";
            dgvMember.DataSource = loadData(memberQuery);
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string bookQuery = "SELECT TOP 5 book_id as [Book ID], title as [Title], author as [Author], genre as [Genre], publication_year as [Publication Year] from tbl_book WHERE IsDeleted = 0";
            dgvBook.DataSource = loadData(bookQuery);
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable loadData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBooksSubMenu);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMembersSubMenu);
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBorrowReturnSubMenu);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlReportsSubMenu);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSettingsSubMenu);
        }

        private Form activeForm = null;

        private void openForm(Form newForm)
        {
            hideDashboard();
            if (activeForm != null)
            {
                activeForm.FormClosed -= showDashboard;
                activeForm.Close();
            }

            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlContainer.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
            newForm.FormClosed += showDashboard;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null) { activeForm.Close(); }
            hideSubMenu();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            openForm(new Inventory("Staff"));
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            openForm(new ManageMembers("Staff"));
        }

        private void btnMemberProfiles_Click(object sender, EventArgs e)
        {
            openForm(new MemberProfiles());
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            openForm(new IssueBook());
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            openForm(new ReturnBook());
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            openForm(new ViewRecords());
        }

        private void btnCirculationReports_Click(object sender, EventArgs e)
        {
            openForm(new CirculationReport());
        }

        private void btnMemberActivityReports_Click(object sender, EventArgs e)
        {
            openForm(new MemberActivityReport());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            lblName.Text = Username + "!";
            loadTable();
            loadCount();
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor;
            dgvOverdueBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvOverdueBook.ColumnHeadersDefaultCellStyle.BackColor;
            dgvOverdueBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvOverdueBook.ColumnHeadersDefaultCellStyle.ForeColor;
            dgvIssuedBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssuedBook.ColumnHeadersDefaultCellStyle.BackColor;
            dgvIssuedBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssuedBook.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            openForm(new ManageMembers("Staff"));
        }

        private void lblMemberSeeAll_Click(object sender, EventArgs e)
        {
            openForm(new MemberProfiles());
        }

        private void lblBookSeeAll_Click(object sender, EventArgs e)
        {
            openForm(new Inventory("Staff"));
        }

        private void btnIssueBook2_Click(object sender, EventArgs e)
        {
            openForm(new IssueBook());
        }

        private void btnManageGenre_Click(object sender, EventArgs e)
        {
            openForm(new ManageGenres("Staff"));
        }

        private void autoLoadDashboard_Tick(object sender, EventArgs e)
        {
            loadCount();
            loadBorrowerStatistics();
            lblDateAndTime.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        private void loadBorrowerStatistics()
        {
            string query = "SELECT tbl_member.membership_type, COUNT(tbl_issue.issue_id) AS total_borrowed FROM tbl_member JOIN tbl_issue ON tbl_member.member_id = tbl_issue.member_id GROUP BY tbl_member.membership_type";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            borrowerstatistics.Series.Clear();
            borrowerstatistics.Titles.Clear();
            borrowerstatistics.Titles.Add("Books Borrowed by Membership Type");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Total Borrowed")
            {
                ChartType = SeriesChartType.Column
            };

            while (dr.Read())
            {
                string membershipType = dr["membership_type"].ToString();
                int totalBorrowed = Convert.ToInt32(dr["total_borrowed"]);

                series.Points.AddXY(membershipType, totalBorrowed);
            }

            dr.Close();
            conn.Close();

            borrowerstatistics.Series.Add(series);
        }
    }
}
