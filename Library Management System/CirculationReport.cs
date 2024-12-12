using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.Charts;
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
    public partial class CirculationReport : Form
    {
        public CirculationReport()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        private void loadData()
        {
            string loadTableQuery = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status]  FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id";
            string query = " SELECT (SELECT COUNT(*) FROM tbl_issue) AS [Total Items Borrowed], (SELECT COUNT(*) FROM tbl_issue WHERE return_date IS NOT NULL) AS [Total Items Returned], (SELECT COUNT(*) FROM tbl_issue WHERE return_date IS NULL AND due_date < GETDATE()) AS [Overdue Items]";

            SqlCommand cmd = new SqlCommand(loadTableQuery, conn);
            SqlCommand cmd2 = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            conn.Open();
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                lblTotalItemsBorrowed.Text = dr["Total Items Borrowed"].ToString();
                lblTotalItemsReturned.Text = dr["Total Items Returned"].ToString();
                lblOverdueItems.Text = dr["Overdue Items"].ToString();
            }
            dr.Close();
            conn.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIssue.DataSource = dt;
            dgvIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIssue.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue.ColumnHeadersDefaultCellStyle.BackColor;
            dgvIssue.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue.ColumnHeadersDefaultCellStyle.ForeColor;
        }



        private void CirculationReport_Load(object sender, EventArgs e)
        {
            loadData();
            cbSearchBy.Text = "Book Title";
        }

        private void searchFilter()
        {
            string query = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status]  FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE 1=1";
            string search = tbSearch.Text;

            if (!string.IsNullOrEmpty(search))
            {
                if (cbSearchBy.Text == "Book Title")
                {
                    query += " AND tbl_book.title LIKE @search";
                }
                else if (cbSearchBy.Text == "ISBN")
                {
                    query += " AND tbl_book.isbn = @search";
                }
                else if (cbSearchBy.Text == "Book ID")
                {
                    if (!int.TryParse(search, out int id))
                    {
                        return;
                    }
                    query += " AND tbl_book.book_id = @search";
                }
            }

            SqlCommand cmd = new SqlCommand(query, conn);

            if (!string.IsNullOrEmpty(search))
            {
                if (cbSearchBy.Text == "Book Title")
                {
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                }
                else if (cbSearchBy.Text == "ISBN" || cbSearchBy.Text == "Book ID")
                {
                    cmd.Parameters.AddWithValue("@search", search);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIssue.DataSource = dt;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvIssue.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook | *.xlsx",
                Title = "Save Excel File",
                FileName = "CirculationReport.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("CirculationReport");

                            int colIndex = 1;
                            for (int i = 0; i < dgvIssue.Columns.Count; i++)
                            {
                                if (dgvIssue.Columns[i] is DataGridViewImageColumn)
                                    continue;

                                worksheet.Cell(1, colIndex).Value = dgvIssue.Columns[i].HeaderText;
                                colIndex++;
                            }

                            for (int i = 0; i < dgvIssue.Rows.Count; i++)
                            {
                                colIndex = 1;
                                for (int j = 0; j < dgvIssue.Columns.Count; j++)
                                {
                                    if (dgvIssue.Columns[j] is DataGridViewImageColumn)
                                        continue;

                                    if (dgvIssue.Rows[i].Cells[j].Value != null)
                                    {
                                        worksheet.Cell(i + 2, colIndex).Value = dgvIssue.Rows[i].Cells[j].Value.ToString();
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
