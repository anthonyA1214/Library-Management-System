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
    public partial class Inventory : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        public Inventory()
        {
            InitializeComponent();
        }

        private void loadLowStocksTable()
        {
            conn.Open();
            string query = "SELECT * from tbl_book WHERE copies_available <= 5";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLowStocks.DataSource = dt;
            dgvLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void loadBookTable()
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
            DataGridViewImageColumn addStockImgCol = new DataGridViewImageColumn
            {
                Image = Properties.Resources.add,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                Name = "addstock",
                HeaderText = "Add Stock"
            };
            if (dgvBook.Columns["addstock"] == null)
            {
                dgvBook.Columns.Add(addStockImgCol);
            }          
        }

        private void pbHideShow_Click(object sender, EventArgs e)
        {
            if (pnlLowStocks.Height == 200)
            {
                pnlLowStocks.Height = 35;
                pnlLowStocksContainer.Height = 55;
                pbHideShow.Image = Properties.Resources.down_arrow;
            }
            else
            {
                pnlLowStocks.Height = 200;
                pnlLowStocksContainer.Height = 220;
                pbHideShow.Image = Properties.Resources.up_arrow;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            pnlStock.Visible = false;
            loadBookTable();
            loadLowStocksTable();
            string query1 = "SELECT author from tbl_book";
            string query2 = "SELECT genre from tbl_book";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();         
            while (dr1.Read())
            {
                string author = dr1[0].ToString();

                if (!cbSearchAuthor.Items.Contains(author))
                {
                    cbSearchAuthor.Items.Add(author);
                }
            }
            dr1.Close();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string genre = dr2[0].ToString();

                if (!cbSearchGenre.Items.Contains(genre))
                {
                    cbSearchGenre.Items.Add(genre);
                }
            }
            dr2.Close();
            conn.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from tbl_book WHERE 1=1";
            if (!string.IsNullOrEmpty(tbSearchTitle.Text))
            {
                query += " AND title LIKE @title";
            }
            if (!string.IsNullOrEmpty(cbSearchAuthor.Text))
            {
                query += " AND author LIKE @author";
            }
            if (!string.IsNullOrEmpty(tbSearchISBN.Text))
            {
                query += " AND isbn LIKE @isbn";
            }
            if (!string.IsNullOrEmpty(cbSearchGenre.Text))
            {
                query += " AND genre LIKE @genre";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (!string.IsNullOrEmpty(tbSearchTitle.Text))
            {
                cmd.Parameters.AddWithValue("@title", "%" + tbSearchTitle.Text + "%");
            }
            if (!string.IsNullOrEmpty(cbSearchAuthor.Text))
            {
                cmd.Parameters.AddWithValue("@author", cbSearchAuthor.Text);
            }
            if (!string.IsNullOrEmpty(tbSearchISBN.Text))
            {
                cmd.Parameters.AddWithValue("@isbn", tbSearchISBN.Text);
            }
            if (!string.IsNullOrEmpty(cbSearchGenre.Text))
            {
                cmd.Parameters.AddWithValue("@genre", cbSearchGenre.Text);
            }
                
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearchTitle.Clear();
            cbSearchAuthor.Text = string.Empty;
            tbSearchISBN.Clear();
            cbSearchGenre.Text = string.Empty;
        }

        int book_id;

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBook.Columns["addstock"].Index)
            {
                book_id = int.Parse(dgvBook.Rows[e.RowIndex].Cells["book_id"].Value.ToString());
                pnlStock.Visible = true;
                tbBookID.Text = book_id.ToString();
            }         
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlStock.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStock.Text))
            {
                MessageBox.Show("Please enter a valid stock number.");
                return;
            }
            string bookid = tbBookID.Text;
            string stock = tbStock.Text;

            string query = "UPDATE tbl_book SET copies_available = copies_available + @stock, total_copies = total_copies + @stock WHERE book_id = @bookid";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                cmd.Parameters.AddWithValue("@stock", stock);
                int checkrow = cmd.ExecuteNonQuery();
                if(checkrow > 0)
                {
                    MessageBox.Show("Stock successfully added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                loadBookTable();
                loadLowStocksTable();
                pnlStock.Visible = false;
            }
        }
    }
}
