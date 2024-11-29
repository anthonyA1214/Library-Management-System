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
        int select, bookid;

        public ManageBooks()
        {
            InitializeComponent();
            pnlSideMenu.Visible = false;
        }

        private void loadTable()
        {
            string query = "SELECT * from tbl_book";
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
            numQuantity.ResetText();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
            loadTable();
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
            int checkrow;
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
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2:
                        query = "UPDATE tbl_book SET title = @title, author = @author, isbn = @isbn, genre = @genre, publication_year = @publicationyear WHERE book_id = @bookid";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@bookid", bookid);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@publicationyear", publicationyear);
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        query = "DELETE from tbl_book WHERE book_id = @bookid";
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@bookid", bookid);
                        checkrow = cmd.ExecuteNonQuery();
                        if (checkrow > 0)
                        {
                            MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                conn.Close();
                clearTexts();
                loadTable();
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
                bookid = int.Parse(dgvBook.Rows[e.RowIndex].Cells["book_id"].Value.ToString());
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
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            select = 0;
        }     
    }
}
