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
    public partial class AdminForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        private string Username;
        public AdminForm(string username)
        {
            InitializeComponent();
            Username = username;
        }

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
            if(SubMenu.Visible == false)
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
            loadMemberTable();
            loadBookTable();
            string query1 = "SELECT COUNT(*) from tbl_book";
            string query2 = "SELECT COUNT(*) from tbl_member";
            string query3 = "SELECT COUNT(*) from tbl_issue WHERE status = 'Issued'";
            //string query4 = "SELECT COUNT(*) from tbl_issue WHERE status = 'Returned'";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            //SqlCommand cmd4 = new SqlCommand(query5, conn);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            //SqlDataAdapter da4 = new SqlDataAdapter(cmd5);

            DataSet ds = new DataSet();

            da1.Fill(ds, "BookCount");
            da2.Fill(ds, "MemberCount");
            da3.Fill(ds, "IssuedCount");
            //da4.Fill(ds, "ReturnedCount");

            lblCountBook.Text = ds.Tables["BookCount"].Rows[0][0].ToString();
            lblCountMember.Text = ds.Tables["MemberCount"].Rows[0][0].ToString();
            lblIssuedBook.Text = ds.Tables["IssuedCount"].Rows[0][0].ToString();
            //label6.Text = ds.Tables["ReturnedCount"].Rows[0][0].ToString();
        } 

        private void loadMemberTable()
        {
            string query = "SELECT TOP 5 member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadBookTable()
        {
            string query = "SELECT TOP 5 book_id as [Book ID], title as [Title], author as [Author], genre as [Genre], publication_year as [Publication Year] from tbl_book WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            openForm(new UserManagement());
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
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            openForm(new ManageBooks());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            openForm(new Inventory());
        }

        private void btnAddEditStaff_Click(object sender, EventArgs e)
        {
            openForm(new AddEditStaff());
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            openForm(new SearchStaff());
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            openForm(new ManageMembers());
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            lblName.Text = Username + "!";
            loadCount();
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void autoLoadCount_Tick(object sender, EventArgs e)
        {
            loadCount();
            lblDateAndTime.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
            
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            openForm(new ManageMembers());
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            openForm(new ManageBooks());
        }

        private void lblMemberSeeAll_Click(object sender, EventArgs e)
        {
            openForm(new MemberProfiles());
        }

        private void lblBookSeeAll_Click(object sender, EventArgs e)
        {
            openForm(new Inventory());
        }

        private void btnIssueBook2_Click(object sender, EventArgs e)
        {
            openForm(new IssueBook());
        }

        private void btnManageGenre_Click(object sender, EventArgs e)
        {
            openForm(new ManageGenres());
        }
    }
}
