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
    public partial class SearchStaff : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        public SearchStaff()
        {
            InitializeComponent();
        }

        private void loadTable()
        {
            conn.Open();
            string query = "SELECT * from tbl_staff";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string name = tbSearchName.Text;
            string contact = tbSearchContact.Text;
            string role = cbSearchRole.Text;

            string query = "SELECT * from tbl_staff WHERE 1=1";

            if (!string.IsNullOrEmpty(tbSearchName.Text))
            {
                query += " AND (first_name LIKE @name OR last_name LIKE @name)";
            }
            if (!string.IsNullOrEmpty(tbSearchContact.Text))
            {
                query += " AND (contact_number LIKE @contact OR email LIKE @contact)";
            }
            if (!string.IsNullOrEmpty(cbSearchRole.Text))
            {
                query += " AND role = @role";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (!string.IsNullOrEmpty(tbSearchName.Text))
            {
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");
            }
            if (!string.IsNullOrEmpty(tbSearchContact.Text))
            {
                cmd.Parameters.AddWithValue("@contact", "%" + contact + "%");
            }
            if (!string.IsNullOrEmpty(cbSearchRole.Text))
            {
                cmd.Parameters.AddWithValue("@role", role);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearchName.Clear();
            tbSearchContact.Clear();
            cbSearchRole.Text = string.Empty;
        }

        private void SearchStaff_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
