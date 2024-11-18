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
        public AdminForm()
        {
            InitializeComponent();            
        }

        private void hideDashboard()
        {
            pnlTitle.Visible = false;
            tlpCounts1.Visible = false;
            tlpCounts2.Visible = false;
        }

        private void showDashboard(object sender, FormClosedEventArgs e)
        {
            pnlTitle.Visible = true;
            tlpCounts1.Visible = true;
            tlpCounts2.Visible = true;
        }

        private void hideSubMenu()
        {
            pnlManageBooksSubMenu.Visible = false;
            pnlManageStaffsSubMenu.Visible = false;
            pnlManageMembersSubMenu.Visible = false;
            pnlBorrowReturnSubMenu.Visible = false;
            pnlReportsSubMenu.Visible = false;
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
            string query1 = "SELECT COUNT(*) from tbl_book";
            string query2 = "SELECT COUNT(*) from tbl_staff";
            string query3 = "SELECT COUNT(*) from tbl_member";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlCommand cmd3 = new SqlCommand(query3, conn);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

            DataSet ds = new DataSet();

            da1.Fill(ds, "BookCount");
            da2.Fill(ds, "StaffCount");
            da3.Fill(ds, "MemberCount");

            lblCountBook.Text = ds.Tables["BookCount"].Rows[0][0].ToString();
            lblCountStaff.Text = ds.Tables["StaffCount"].Rows[0][0].ToString();
            lblCountMember.Text = ds.Tables["MemberCount"].Rows[0][0].ToString();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlManageBooksSubMenu);
        }

        private void btnManageStaffs_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlManageStaffsSubMenu);
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlManageMembersSubMenu);
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBorrowReturnSubMenu);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlReportsSubMenu);
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

        private void btnAddEditBook_Click(object sender, EventArgs e)
        {
            openForm(new AddEditBook());
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

        private void btnAddEditMember_Click(object sender, EventArgs e)
        {
            openForm(new AddEditMember());
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            openForm(new SearchMember());
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            openForm(new IssueBook());
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            openForm(new ReturnBook());
        }

        private void btnCurrentLoansOverview_Click(object sender, EventArgs e)
        {
            openForm(new CurrentLoansOverview());
        }

        private void btnCirculationReports_Click(object sender, EventArgs e)
        {
            openForm(new CirculationReport());
        }

        private void btnMemberActivityReports_Click(object sender, EventArgs e)
        {
            openForm(new MemberActivityReport());
        }

        private void btnOverdueItemsReports_Click(object sender, EventArgs e)
        {
            openForm(new OverdueItemsReport());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            loadCount();            
        }

        private void autoLoadCount_Tick(object sender, EventArgs e)
        {
            loadCount();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnBooksMoreInfo_Click(object sender, EventArgs e)
        {
            openForm(new Inventory());
        }

        private void btnStaffsMoreInfo_Click(object sender, EventArgs e)
        {
            openForm(new SearchStaff());
        }

        private void btnMemberMoreInfo_Click(object sender, EventArgs e)
        {
            openForm(new SearchMember());
        }
    }
}
