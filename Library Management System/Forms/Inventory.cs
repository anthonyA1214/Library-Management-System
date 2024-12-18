﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Collections;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Math;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class Inventory : Form
    {
        SqlConnection conn = dbConnection.GetConnection();
        int bookid;

        private string userRole;

        public Inventory(string userrole)
        {
            InitializeComponent();
            userRole = userrole;
        }

        private void HandleLogin(string userRole)
        {
            if (userRole == "Staff")
            {
                dgvBook.Columns["add"].Visible = false;
            }
            else if (userRole == "Admin")
            {
                dgvBook.Columns["add"].Visible = true;
            }
        }

        private void loadTable()
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity], CASE WHEN quantity > 0 THEN 'Available' ELSE 'Unavailable' END AS [Availability Status] from tbl_book WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBook.CellFormatting += dgvBook_CellFormatting;

            DataGridViewImageColumn addImgCol = new DataGridViewImageColumn
            {
                Name = "add",
                HeaderText = string.Empty,
                Image = Properties.Resources.add,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            if (dgvBook.Columns["add"] == null)
            {
                dgvBook.Columns.Add(addImgCol);
            }
            HandleLogin(userRole);
        }

        private void loadGenre()
        {
            cbGenre.Items.Clear();
            try
            {
                string query = "SELECT genre_name FROM tbl_genre";
                cbGenre.Items.Add("All");
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbGenre.Items.Add(reader["genre_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void clearTexts()
        {
            tbTitle.Clear();
            tbAuthor.Clear();
            numQuantity.Value = 0;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            loadTable();
            loadGenre();
            pnlSideMenu.Visible = false;
            tbTitle.Enabled = false;
            tbAuthor.Enabled = false;
            cbSearchBy.Text = "Title";
            cbGenre.Text = "All";
            cbAvailabilityStatus.Text = "All";
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor;          
        }

        private void dgvBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBook.Columns[e.ColumnIndex].Name == "Quantity" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int quantity))
                {
                    if (quantity == 0)
                    {
                        dgvBook.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral; 
                    }
                    else if (quantity < 5)
                    {
                        dgvBook.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 153); 
                    }
                    else
                    {
                        dgvBook.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 225); 
                    }
                }
            }
        }

        private void dgvBook_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvBook.Columns[e.ColumnIndex].Name == "add")
            {
                e.ToolTipText = "Add Stock";
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBook.Columns["add"].Index)
            {
                string query = "SELECT * from tbl_book WHERE book_id = @bookid";
                bookid = int.Parse(dgvBook.Rows[e.RowIndex].Cells["Book ID"].Value.ToString());
                clearTexts();
                pnlSideMenu.Visible = true;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                tbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
                tbAuthor.Text = ds.Tables[0].Rows[0][2].ToString();              
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit2_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            clearTexts();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(numQuantity.Text);
            string query = "UPDATE tbl_book SET quantity = quantity + @quantity WHERE book_id = @bookid";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                int checkrow = cmd.ExecuteNonQuery();
                if (checkrow > 0)
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
                loadTable();
                pnlSideMenu.Visible = false;
            }
        }

        private void searchFilter()
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity], CASE WHEN quantity > 0 THEN 'Available' ELSE 'Unavailable' END AS[Availability Status] FROM tbl_book WHERE IsDeleted = 0";

            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                string search = tbSearch.Text;
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
                    query += " AND isbn LIKE @search";
                }
                else if (cbSearchBy.Text == "Publication Year")
                {
                    query += " AND publication_year LIKE @search";
                }
                else if (cbSearchBy.Text == "ID")
                {
                    if (!int.TryParse(search, out int id))
                    {
                        return;
                    }
                    query += " AND book_id LIKE @search";
                }
            }

            if (cbGenre.SelectedItem.ToString() != "All")
            {
                string genre = cbGenre.SelectedItem.ToString();
                query += " AND genre LIKE @genre";
            }

            if (cbAvailabilityStatus.Text != "All")
            {
                if (cbAvailabilityStatus.Text == "Available")
                {
                    query += " AND quantity > 0";
                }
                else if (cbAvailabilityStatus.Text == "Unavailable")
                {
                    query += " AND quantity = 0";
                }
            }

            SqlCommand cmd = new SqlCommand(query, conn);

            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                string search = tbSearch.Text;
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }

            if (cbGenre.SelectedItem.ToString() != "All")
            {
                string genre = cbGenre.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@genre", genre);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvBook.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook | *.xlsx",
                Title = "Save Excel File",
                FileName = "Inventory.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Inventory");

                            int colIndex = 1;
                            for (int i = 0; i < dgvBook.Columns.Count; i++)
                            {
                                if (dgvBook.Columns[i] is DataGridViewImageColumn)
                                    continue;

                                worksheet.Cell(1, colIndex).Value = dgvBook.Columns[i].HeaderText;
                                colIndex++;
                            }

                            for (int i = 0; i < dgvBook.Rows.Count; i++)
                            {
                                colIndex = 1;
                                for (int j = 0; j < dgvBook.Columns.Count; j++)
                                {
                                    if (dgvBook.Columns[j] is DataGridViewImageColumn)
                                        continue;

                                    if (dgvBook.Rows[i].Cells[j].Value != null)
                                    {
                                        worksheet.Cell(i + 2, colIndex).Value = dgvBook.Rows[i].Cells[j].Value.ToString();
                                    }
                                    colIndex++;
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Export successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void cbAvailabilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchFilter();
        }
    }
}
