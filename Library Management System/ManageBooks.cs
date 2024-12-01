using Guna.UI2.WinForms;
using Library_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ManageBooks : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");
        int select, bookid, checkrow;

        public ManageBooks()
        {
            InitializeComponent();
            pnlSideMenu.Visible = false;
        }

        private void loadTable()
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn updateImgCol = new DataGridViewImageColumn
            {
                Name = "update",
                HeaderText = string.Empty,
                Image = Properties.Resources.edit,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            DataGridViewImageColumn deleteImgCol = new DataGridViewImageColumn
            {
                Name = "delete",
                HeaderText = string.Empty,
                Image = Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            if (dgvBook.Columns["update"] == null)
            {
                dgvBook.Columns.Add(updateImgCol);
            }
            if (dgvBook.Columns["delete"] == null)
            {
                dgvBook.Columns.Add(deleteImgCol);
            }
        }

        private void clearTexts()
        {
            tbTitle.Clear();
            tbAuthor.Clear();
            tbISBN.Clear();
            cbGenre.Text = string.Empty;
            dtpPublicationYear.Text = string.Empty;
            numQuantity.Value = 0;
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
            loadTable();
            cbSearchBy.Text = "Title";
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            lblSideMenu.Text = "ADD BOOK";
            select = 1;
            clearTexts();
            pnlSideMenu.Visible = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (select == 1 && tbTitle.Text == "" && tbAuthor.Text == "" && tbISBN.Text == "" && cbGenre.Text == "" && numQuantity.Text == "0")
            {
                MessageBox.Show("All fields are required.", "Input error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string isbn = tbISBN.Text;
            string genre = cbGenre.Text;
            int publicationyear = int.Parse(dtpPublicationYear.Text);
            int quantity = int.Parse(numQuantity.Text);
            string query;

            try
            {
                if(select == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this book?","Confirm Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No) 
                        return;
                }
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                switch (select)
                {
                    case 1:
                        query = "INSERT into tbl_book(title,author,isbn,genre,publication_year,quantity) values(@title,@author,@isbn,@genre,@publicationyear,@quantity)";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@publicationyear", publicationyear);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        checkrow = cmd.ExecuteNonQuery();
                        if(checkrow > 0)
                        {
                            MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlSideMenu.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2:
                        query = "UPDATE tbl_book SET title = @title, author = @author, isbn = @isbn, genre = @genre, publication_year = @publicationyear, quantity = @quantity WHERE book_id = @bookid";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@bookid", bookid);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@publicationyear", publicationyear);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlSideMenu.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); loadTable();
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBook_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvBook.Columns[e.ColumnIndex].Name == "update")
            {
                e.ToolTipText = "Update";
            }
            if (dgvBook.Columns[e.ColumnIndex].Name == "delete")
            {
                e.ToolTipText = "Delete";
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBook.Columns["update"].Index)
            {
                string query = "SELECT * from tbl_book WHERE book_id = @bookid";
                bookid = int.Parse(dgvBook.Rows[e.RowIndex].Cells["Book ID"].Value.ToString());
                select = 2;
                clearTexts();
                lblSideMenu.Text = "UPDATE BOOK";
                pnlSideMenu.Visible = true;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                tbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
                tbAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                tbISBN.Text = ds.Tables[0].Rows[0][3].ToString();
                cbGenre.Text = ds.Tables[0].Rows[0][4].ToString();
                int publicationYear = int.Parse(ds.Tables[0].Rows[0][5].ToString());
                dtpPublicationYear.Value = new DateTime(publicationYear, 1, 1);
                numQuantity.Value = decimal.Parse(ds.Tables[0].Rows[0][6].ToString());
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBook.Columns["delete"].Index)
            {
                string query = "UPDATE tbl_book SET IsDeleted = 1 WHERE book_id = @bookid";
                bookid = int.Parse(dgvBook.Rows[e.RowIndex].Cells["Book ID"].Value.ToString());
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@bookid", bookid);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No) return;
                    checkrow = cmd.ExecuteNonQuery();
                    if (checkrow > 0)
                    {
                        MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); clearTexts(); loadTable();
                }                
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadTable();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0";
            string search = tbSearch.Text;
            if (cbSearchBy.Text == "Title")
            {
                query += " AND title LIKE @title";
            }
            else if (cbSearchBy.Text == "Author")
            {
                query += " AND author LIKE @author";
            }
            else if (cbSearchBy.Text == "ISBN")
            {
                query += " AND isbn = @isbn";
            }
            else if (cbSearchBy.Text == "Genre")
            {
                query += " AND genre = @genre";
            }
            else if (cbSearchBy.Text == "Publication Year")
            {
                query += " AND publication_year = @publicationyear";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy.Text == "Title")
            {
                cmd.Parameters.AddWithValue("@title", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "Author")
            {
                cmd.Parameters.AddWithValue("@author", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "ISBN")
            {
                cmd.Parameters.AddWithValue("@isbn", search);
            }
            else if (cbSearchBy.Text == "Genre")
            {
                cmd.Parameters.AddWithValue("@genre", search);
            }
            else if (cbSearchBy.Text == "Publication Year")
            {
                cmd.Parameters.AddWithValue("@publicationyear", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
        }     
    }
}
