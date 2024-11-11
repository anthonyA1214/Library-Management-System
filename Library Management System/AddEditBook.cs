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
    public partial class AddEditBook : Form
    {
        SqlConnection conn = new SqlConnection();

        public AddEditBook()
        {
            InitializeComponent();
        }

        private void clearTexts()
        {
            tbTitle.Clear();
            tbAuthor.Clear();
            tbISBN.Clear();
            tbGenre.Clear();
            dtpPublicationYear.Text = string.Empty;
            tbTotalCopies.Clear();
        }
        private void loadTable()
        {
            conn.Open();
            string query = "SELECT * from tbl_book";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void AddEditBook_Load(object sender, EventArgs e)
        {
            pnlSideMenu1.Visible = false;
        }
    }
}
