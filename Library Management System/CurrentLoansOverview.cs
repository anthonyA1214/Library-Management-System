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
            cbLoanStatus.Text = string.Empty;
            cbDateRange.Text = string.Empty;
        }

        private void loadTable()
        {
            string query = "SELECT * from tbl_issue";
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
    }
}
