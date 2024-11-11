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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        int select, book_id;

        public AddEditBook()
        {
            InitializeComponent();
        }

        private void clearTexts()
        {
            tbBookID.Clear();
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

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (select == 2 || select == 3)
                {
                    if (dgvBook.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                    {
                        book_id = int.Parse(dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }

                    string query = "SELECT * from tbl_book WHERE book_id = " + book_id + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    tbBookID.Text = ds.Tables[0].Rows[0][0].ToString();
                    tbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
                    tbAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                    tbISBN.Text = ds.Tables[0].Rows[0][3].ToString();
                    tbGenre.Text = ds.Tables[0].Rows[0][4].ToString();
                    int publicationYear = int.Parse(ds.Tables[0].Rows[0][5].ToString());
                    dtpPublicationYear.Value = new DateTime(publicationYear, 1, 1);
                    tbTotalCopies.Text = ds.Tables[0].Rows[0][7].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void disableEdit()
        {
            tbTitle.ReadOnly = true;
            tbAuthor.ReadOnly = true;
            tbISBN.ReadOnly = true;
            tbGenre.ReadOnly = true;
            dtpPublicationYear.Enabled = false;
            tbTotalCopies.ReadOnly = true;
        }

        private void enableEdit()
        {
            tbTitle.ReadOnly = false;
            tbAuthor.ReadOnly = false;
            tbISBN.ReadOnly = false;
            tbGenre.ReadOnly = false;
            dtpPublicationYear.Enabled = true;
            tbTotalCopies.ReadOnly = false;
        }

        private void AddEditBook_Load(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
            loadTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "ADD BOOK";
            select = 1;
            enableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "UPDATE BOOK";
            select = 2;
            enableEdit();
            clearTexts();
            tbTotalCopies.ReadOnly = true;
            pnlSideMenu.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "DELETE BOOK";
            select = 3;
            disableEdit();
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            select = 0;
            loadTable();
            clearTexts();
            enableEdit();
            pnlSideMenu.Visible = false;           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string isbn = tbISBN.Text;
            string genre = tbGenre.Text;
            int publicationyear = int.Parse(dtpPublicationYear.Text);
            int totalcopies = int.Parse(tbTotalCopies.Text);
            int copiesavailable = totalcopies;
            string query;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                switch (select)
                {
                    case 1:
                        query = "INSERT into tbl_book(title,author,isbn,genre,publication_year,copies_available,total_copies) values(@title,@author,@isbn,@genre,@publicationyear,@copiesavailable,@totalcopies)";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@publicationyear", publicationyear);
                        cmd.Parameters.AddWithValue("@copiesavailable", copiesavailable);
                        cmd.Parameters.AddWithValue("@totalcopies", totalcopies);

                        cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        query = "UPDATE tbl_book SET title = @title, author = @author, isbn = @isbn, genre = @genre, publication_year = @publicationyear WHERE book_id = " + book_id + "";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@publicationyear", publicationyear);
                        cmd.ExecuteNonQuery();
                        break;
                    case 3:
                        query = "DELETE from tbl_book WHERE book_id = " + book_id + "";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                clearTexts();
                loadTable();
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
        }      
    }
}
