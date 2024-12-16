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
    public partial class ManageGenres : Form
    {
        private string userRole;

        public ManageGenres(string userrole)
        {
            InitializeComponent();
            userRole = userrole;
        }

        private void HandleLogin(string userRole)
        {
            if (userRole == "Staff")
            {
                dgvGenre.Columns["delete"].Visible = false;
            }
            else if (userRole == "Admin")
            {
                dgvGenre.Columns["delete"].Visible = true;
            }
        }

        SqlConnection conn = dbConnection.GetConnection();
        int checkrow;

        private void loadTable()
        {
            string query = "SELECT genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGenre.DataSource = dt;
            dgvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn deleteImgCol = new DataGridViewImageColumn
            {
                Name = "delete",
                HeaderText = string.Empty,
                Image = Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            if (dgvGenre.Columns["delete"] == null)
            {
                dgvGenre.Columns.Add(deleteImgCol);
            }
            HandleLogin(userRole);
        }

        private void clearTexts()
        {
            tbGenreName.Clear();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (pnlAddGenre.Visible == false) pnlAddGenre.Visible = true; else pnlAddGenre.Visible = false;
        }

        private void btnSaveGenre_Click(object sender, EventArgs e)
        {
            string genre = tbGenreName.Text.Trim();
            if (string.IsNullOrEmpty(tbGenreName.Text))
            {
                MessageBox.Show("Please enter a genre name.");
                return;
            }
            string query = "INSERT into tbl_genre(genre_name) values(@genre)";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this genre?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    checkrow = cmd.ExecuteNonQuery();
                    if (checkrow > 0)
                    {
                        MessageBox.Show("Genre added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadTable();
                        clearTexts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the genre.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("This genre name already exists.", "Duplicate Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    conn.Close();
                }
            }              
        }

        private void ManageGenres_Load(object sender, EventArgs e)
        {
            loadTable();
            pnlAddGenre.Visible = false;
            dgvGenre.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvGenre.ColumnHeadersDefaultCellStyle.BackColor;
            dgvGenre.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvGenre.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void dgvGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvGenre.Columns["delete"].Index)
            {
                string query = "UPDATE tbl_genre SET IsDeleted = 1 WHERE genre_name = @genre";
                string genre = dgvGenre.Rows[e.RowIndex].Cells["Genre Name"].Value.ToString();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this genre?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No) return;
                    checkrow = cmd.ExecuteNonQuery();
                    if (checkrow > 0)
                    {
                        MessageBox.Show("Genre deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the genre.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    loadTable();
                }
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 0 AND genre_name LIKE @search";
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadTable(); return;
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGenre.DataSource = dt;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlAddGenre.Visible = false;
        }

        private void dgvGenre_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvGenre.Columns[e.ColumnIndex].Name == "delete")
            {
                e.ToolTipText = "Delete";
            }
        }
    }
}
