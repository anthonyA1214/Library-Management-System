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
    public partial class StaffApproval : Form
    {
        public StaffApproval()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        private void loadTable()
        {
            string query = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStaff.DataSource = dt;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn approveImgCol = new DataGridViewImageColumn
            {
                Name = "approve",
                HeaderText = string.Empty,
                Image = Properties.Resources.check,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            DataGridViewImageColumn rejectImgCol = new DataGridViewImageColumn
            {
                Name = "reject",
                HeaderText = string.Empty,
                Image = Properties.Resources.cancel,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            if (dgvStaff.Columns["approve"] == null)
            {
                dgvStaff.Columns.Add(approveImgCol);
            }
            if (dgvStaff.Columns["reject"] == null)
            {
                dgvStaff.Columns.Add(rejectImgCol);
            }
            dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvStaff.ColumnHeadersDefaultCellStyle.BackColor;
            dgvStaff.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int staffid, checkrow;

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvStaff.Columns["approve"].Index)
            {
                string query = "UPDATE tbl_staff SET IsApproved = 1 WHERE staff_id = @staffid";
                staffid = int.Parse(dgvStaff.Rows[e.RowIndex].Cells["Staff ID"].Value.ToString());
                try
                {
                    conn.Open();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to approve this signup?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No) return;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffid", staffid);

                    checkrow = cmd.ExecuteNonQuery();
                    if (checkrow > 0)
                    {
                        MessageBox.Show("Signup request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to approve the signup request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvStaff.Columns["reject"].Index)
            {
                string query = "DELETE FROM tbl_staff WHERE staff_id = @staffid";
                staffid = int.Parse(dgvStaff.Rows[e.RowIndex].Cells["Staff ID"].Value.ToString());
                try
                {
                    conn.Open();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to reject this signup?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No) return;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffid", staffid);     
                    
                    checkrow = cmd.ExecuteNonQuery();

                    if (checkrow > 0)
                    {
                        MessageBox.Show("Signup request rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to reject the signup request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvStaff_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (dgvStaff.Columns[e.ColumnIndex].Name == "approve")
            {
                e.ToolTipText = "Approve";
            }
            if (dgvStaff.Columns[e.ColumnIndex].Name == "reject")
            {
                e.ToolTipText = "Reject";
            }
        }

        private void StaffApproval_Load(object sender, EventArgs e)
        {
            loadTable();
            cbSearchBy.Text = "Name";
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 0";
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadTable(); return;
            }

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
                query += " AND staff_id = @search";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy.Text == "Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "Username")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            else if (cbSearchBy.Text == "ID")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStaff.DataSource = dt;
        }
    }
}
