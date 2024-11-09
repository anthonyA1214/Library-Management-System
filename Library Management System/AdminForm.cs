using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            hideSubMenu();
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
            if (activeForm != null) { activeForm.Close(); }
            activeForm = newForm;           
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;
            pnlContainer.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null) { activeForm.Close(); }
        }

        private void btnAddEditBook_Click(object sender, EventArgs e)
        {
            openForm(new AddEditBook());
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            openForm(new SearchBook());
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
    }
}
