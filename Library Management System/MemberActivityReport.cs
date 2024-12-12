using ClosedXML.Excel;
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
    public partial class MemberActivityReport : Form
    {
        public MemberActivityReport()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");


        private void loadTable()
        {
            string query = "SELECT tbl_member.member_id AS [Member ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], COUNT(tbl_issue.issue_id) AS [Total Borrowed Books], SUM(CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.issue_id IS NOT NULL THEN 1 ELSE 0 END) AS [Currently Borrowed], SUM(CASE WHEN tbl_issue.return_date IS NOT NULL THEN 1 ELSE 0 END) AS [Returned Books] FROM tbl_member LEFT JOIN tbl_issue ON tbl_member.member_id = tbl_issue.member_id GROUP BY tbl_member.member_id, tbl_member.first_name, tbl_member.last_name";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void MemberActivityReport_Load(object sender, EventArgs e)
        {
            cbSearchBy.Text = "Name";
            loadTable();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT tbl_member.member_id AS [Member ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], COUNT(tbl_issue.issue_id) AS [Total Borrowed Books], SUM(CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.issue_id IS NOT NULL THEN 1 ELSE 0 END) AS [Currently Borrowed], SUM(CASE WHEN tbl_issue.return_date IS NOT NULL THEN 1 ELSE 0 END) AS [Returned Books] FROM tbl_member LEFT JOIN tbl_issue ON tbl_member.member_id = tbl_issue.member_id WHERE 1=1";
            string search = tbSearch.Text;

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                loadTable(); return;
            }

            if (cbSearchBy.Text == "Name")
            {
                query += " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search";
            }
            else if (cbSearchBy.Text == "ID")
            {
                if (!int.TryParse(search, out int id))
                {
                    return;
                }
                query += " AND tbl_member.member_id = @search";
            }

            query += " GROUP BY tbl_member.member_id, tbl_member.first_name, tbl_member.last_name ORDER BY [Total Borrowed Books] DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy.Text == "Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy.Text == "ID")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvMember.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook | *.xlsx",
                Title = "Save Excel File",
                FileName = "MemberActivityReport.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("MemberActivityReport");

                            int colIndex = 1;
                            for (int i = 0; i < dgvMember.Columns.Count; i++)
                            {
                                if (dgvMember.Columns[i] is DataGridViewImageColumn)
                                    continue;

                                worksheet.Cell(1, colIndex).Value = dgvMember.Columns[i].HeaderText;
                                colIndex++;
                            }

                            for (int i = 0; i < dgvMember.Rows.Count; i++)
                            {
                                colIndex = 1;
                                for (int j = 0; j < dgvMember.Columns.Count; j++)
                                {
                                    if (dgvMember.Columns[j] is DataGridViewImageColumn)
                                        continue;

                                    if (dgvMember.Rows[i].Cells[j].Value != null)
                                    {
                                        worksheet.Cell(i + 2, colIndex).Value = dgvMember.Rows[i].Cells[j].Value.ToString();
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
    }
}
