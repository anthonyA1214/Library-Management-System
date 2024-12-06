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

        private void loadBookTable()
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecycleBin.DataSource = dt;
            dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadImgCol();
        }

        private void loadMemberTable()
        {
            string query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecycleBin.DataSource = dt;
            dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadImgCol();
        }

        private void loadStaffTable()
        {
            string query = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 1 AND IsApproved = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecycleBin.DataSource = dt;
            dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadImgCol();
        }

        private void loadGenreTable()
        {
            string query = "SELECT genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecycleBin.DataSource = dt;
            dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadImgCol();
        }

        private void loadImgCol()
        {
            DataGridViewImageColumn restoreImgCol = new DataGridViewImageColumn()
            {
                Name = "restore",
                HeaderText = string.Empty,
                Image = Properties.Resources.restorefromtrash,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            DataGridViewImageColumn deleteImgCol = new DataGridViewImageColumn()
            {
                Name = "delete",
                HeaderText = string.Empty,
                Image = Properties.Resources.deleteforever,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            if (dgvRecycleBin.Columns["restore"] == null)
            {
                dgvRecycleBin.Columns.Add(restoreImgCol);
            }
            if (dgvRecycleBin.Columns["delete"] == null)
            {
                dgvRecycleBin.Columns.Add(deleteImgCol);
            }

            dgvRecycleBin.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvRecycleBin.ColumnHeadersDefaultCellStyle.BackColor;
            dgvRecycleBin.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvRecycleBin.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void loadTable()
        {
            dgvRecycleBin.Columns.Clear();
            if (cbSelectTable.Text == "Book")
            {
                loadBookTable();
            }
            else if (cbSelectTable.Text == "Member")
            {
                loadMemberTable();
            }
            else if (cbSelectTable.Text == "Staff")
            {
                loadStaffTable();
            }
            else if (cbSelectTable.Text == "Genre")
            {
                loadGenreTable();
            }
        }

        private void loadSearchBy()
        {
            cbSearchBy.Items.Clear();
            if (cbSelectTable.Text == "Book")
            {                
                cbSearchBy.Items.Add("Title");
                cbSearchBy.Items.Add("Author");
                cbSearchBy.Items.Add("ISBN");
                cbSearchBy.Items.Add("Publication Year");
                cbSearchBy.Items.Add("ID");
                cbSearchBy.Text = "Title";
            }
            else if (cbSelectTable.Text == "Member")
            {          
                cbSearchBy.Items.Add("Name");
                cbSearchBy.Items.Add("ID");
                cbSearchBy.Text = "Name";
            }
            else if (cbSelectTable.Text == "Staff")
            {              
                cbSearchBy.Items.Add("Name");
                cbSearchBy.Items.Add("Username");
                cbSearchBy.Items.Add("ID");
                cbSearchBy.Text = "Name";
            }
            else if (cbSelectTable.Text == "Genre")
            {                
                cbSearchBy.Items.Add("Name");
                cbSearchBy.Items.Add("ID");
                cbSearchBy.Text = "Name";
            }
        }

        private void RecycleBin_Load(object sender, EventArgs e)
        {
            cbSelectTable.Text = "Book";
            loadTable();
            loadSearchBy();
        }
           
        private void cbSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTable();
            loadSearchBy();
        }

        private void dgvRecycleBin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "";
            string idCol = "";
            string tableName = cbSelectTable.SelectedItem.ToString();
            int checkrow;
            SqlCommand cmd = new SqlCommand();
            if (e.ColumnIndex >= 0 && e.ColumnIndex == dgvRecycleBin.Columns["restore"].Index)
            {
                switch (tableName)
                {
                    case "Book":                      
                        query = "UPDATE tbl_book SET IsDeleted = 0 WHERE book_id = @id";
                        idCol = "Book ID";
                        break;
                    case "Member":
                        query = "UPDATE tbl_member SET IsDeleted = 0 WHERE member_id = @id";
                        idCol = "Member ID";
                        break;
                    case "Staff":
                        query = "UPDATE tbl_staff SET IsDeleted = 0 WHERE staff_id = @id";
                        idCol = "Staff ID";
                        break;
                    case "Genre":
                        query = "UPDATE tbl_genre SET IsDeleted = 0 WHERE genre_id = @id";
                        idCol = "Genre ID";
                        break;
                }
                try
                {
                    int id = int.Parse(dgvRecycleBin.Rows[e.RowIndex].Cells[idCol].Value.ToString());

                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to restore this {tableName} record?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No) return;

                    conn.Open();
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@id", id);

                    checkrow = cmd.ExecuteNonQuery();

                    if(checkrow > 0)
                    {
                        MessageBox.Show($"{tableName} record restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to restore {tableName} record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    loadTable();
                    conn.Close();
                }              
            }

            if (e.ColumnIndex >= 0 && e.ColumnIndex == dgvRecycleBin.Columns["delete"].Index)
            {
                switch (tableName)
                {
                    case "Book":
                        query = "DELETE FROM tbl_book WHERE book_id = @id";
                        idCol = "Book ID";
                        break;
                    case "Member":
                        query = "DELETE FROM tbl_member WHERE member_id = @id";
                        idCol = "Member ID";
                        break;
                    case "Staff":
                        query = "DELETE FROM tbl_staff WHERE staff_id = @id";
                        idCol = "Staff ID";
                        break;
                    case "Genre":
                        query = "DELETE FROM tbl_genre WHERE genre_id = @id";
                        idCol = "Genre ID";
                        break;
                }

                try
                {
                    int id = int.Parse(dgvRecycleBin.Rows[e.RowIndex].Cells[idCol].Value.ToString());

                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to permanently delete this {tableName} record? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.No) return;

                    conn.Open();
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@id", id);

                    checkrow = cmd.ExecuteNonQuery();

                    if (checkrow > 0)
                    {
                        MessageBox.Show($"{tableName} record deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete {tableName} record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    loadTable();
                    conn.Close();
                }
            }
        }

        private void dgvRecycleBin_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvRecycleBin.Columns[e.ColumnIndex].Name == "restore")
            {
                e.ToolTipText = "Restore from trash";
            }
            if (dgvRecycleBin.Columns[e.ColumnIndex].Name == "delete")
            {
                e.ToolTipText = "Delete Forever";
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            string tableName = cbSelectTable.SelectedItem.ToString();
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(search))
            {
                loadTable(); return;
            }

            switch (tableName)
            {
                case "Book":
                    query = "SELECT book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 1";

                    if (cbSearchBy.Text == "Title")
                    {
                        query += " AND title LIKE @search";
                    }
                    else if (cbSearchBy.Text == "Author")
                    {
                        query += " AND author LIKE @search";
                    }
                    else if (cbSearchBy.Text == "ISBN")
                    {
                        query += " AND isbn = @search";
                    }
                    else if (cbSearchBy.Text == "Publication Year")
                    {
                        query += " AND publication_year = @search";
                    }
                    else if (cbSearchBy.Text == "ID")
                    {
                        if (!int.TryParse(search, out int id))
                        {
                            return;
                        }
                        query += " AND book_id = @search";
                    }
                    break;

                case "Member":
                    query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 1";
                    if (cbSearchBy.Text == "Name")
                    {
                        query += " AND CONCAT(first_name, ' ', last_name) LIKE @search";
                    }
                    else if (cbSearchBy.Text == "ID")
                    {
                        if (!int.TryParse(search, out int id))
                        {
                            return;
                        }
                        query += " AND member_id = @search";
                    }
                    break;

                case "Staff":
                    query = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 1 AND IsApproved = 1";
                    if (cbSearchBy.Text == "Name")
                    {
                        query += " AND CONCAT(first_name, ' ', last_name) LIKE @search";
                    }
                    else if (cbSearchBy.Text == "Username")
                    {
                        query += " AND username = @search";
                    }
                    else if (cbSearchBy.Text == "ID")
                    {
                        if (!int.TryParse(search, out int id))
                        {
                            return;
                        }
                        query += " AND staff_id = @search";
                    }
                    break;

                case "Genre":
                    query = "SELECT genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 1";
                    if (cbSearchBy.Text == "Name")
                    {
                        query += " AND genre_name LIKE @search";
                    }
                    else if (cbSearchBy.Text == "ID")
                    {
                        if (!int.TryParse(search, out int id))
                        {
                            return;
                        }
                        query += " AND genre_id = @search";
                    }
                    break;
            }

            SqlCommand cmd = new SqlCommand(query, conn);

            if (cbSearchBy.Text == "Title" || cbSearchBy.Text == "Author" || cbSearchBy.Text == "Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else
            {
                cmd.Parameters.AddWithValue("@search", search); 
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRecycleBin.DataSource = dt;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
