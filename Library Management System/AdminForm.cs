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
    }
}
