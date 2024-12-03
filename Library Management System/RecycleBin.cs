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
    public partial class RecycleBin : Form
    {
        public RecycleBin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        private void RecycleBin_Load(object sender, EventArgs e)
        {
            cbSelectTable.Text = "Book";
            loadBookTable();
        }

        private void loadBookTable()
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecycleBin.DataSource = dt;
            dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn restoreImgCol = new DataGridViewImageColumn()
            {
                Name = "restore",
                HeaderText = string.Empty,
                Image = Properties.Resources
            };
        }
    }
}
