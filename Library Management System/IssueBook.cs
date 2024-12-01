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

namespace Library_Management_System
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        int bookid, memberid;

        private void loadMemberTable()
        {
            string query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name] from tbl_member WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadBookTable()
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void clearTexts()
        {
            lblMemberID.Text = "";
            lblMemberName.Text = "";
            lblBookID.Text = "";
            lblBookTitle.Text = "";
            lblBookAuthor.Text = "";
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBook.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                bookid = int.Parse(dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString());

                string query = "SELECT * from tbl_book WHERE book_id = @bookid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                lblBookID.Text = ds.Tables[0].Rows[0][0].ToString();
                lblBookTitle.Text = ds.Tables[0].Rows[0][1].ToString(); 
                lblBookAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            }
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMember.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                memberid = int.Parse(dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString());

                string query = "SELECT * from tbl_member WHERE member_id = @memberid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@memberid", memberid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                lblMemberID.Text = ds.Tables[0].Rows[0][0].ToString();
                lblMemberName.Text = ds.Tables[0].Rows[0][1].ToString() + " " + ds.Tables[0].Rows[0][2].ToString();
            }
        }
       
        private void IssueBook_Load(object sender, EventArgs e)
        {
            loadMemberTable();
            loadBookTable();
            clearTexts();
            cbSearchBy1.Text = "Name";
            cbSearchBy2.Text = "Title";
            lblMemberName.AutoEllipsis = true;
            lblBookTitle.AutoEllipsis = true;
            lblBookAuthor.AutoEllipsis = true;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor;
            dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            DateTime issuedate = dtpIssueDate.Value;
            DateTime duedate = dtpDueDate.Value;

            if (memberid == 0 || bookid == 0)
            {
                MessageBox.Show("Please select Borrower or Book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                string checkQuery = "SELECT quantity from tbl_book WHERE book_id = @bookid";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@bookid", bookid);
                int copiesAvailable = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (copiesAvailable <= 0)
                {
                    MessageBox.Show("Insufficient copies.", "Not enough copies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to issue this book?", "Confirm Issuance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    string issueQuery = "INSERT into tbl_issue (book_id, member_id, issue_date, due_date, status) VALUES(@bookid, @memberid, @issuedate, @duedate, 'Issued')";
                    SqlCommand issueCmd = new SqlCommand(issueQuery, conn);
                    issueCmd.Parameters.AddWithValue("@bookid", bookid);
                    issueCmd.Parameters.AddWithValue("@memberid", memberid);
                    issueCmd.Parameters.AddWithValue("@issuedate", issuedate);
                    issueCmd.Parameters.AddWithValue("@duedate", duedate);
                    int checkissue = issueCmd.ExecuteNonQuery();

                    string updateQuery = "UPDATE tbl_book SET quantity = quantity - 1 WHERE book_id = @bookid";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@bookid", bookid);
                    int checkupdate = updateCmd.ExecuteNonQuery();

                    if (checkissue > 0 && checkupdate > 0)
                    {
                        MessageBox.Show("Issued book successfully!\nInventory updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearTexts();
                    }
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
                loadMemberTable();
            }
        }

        private void tbSearch1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name] from tbl_member WHERE IsDeleted = 0";
            string search = tbSearch1.Text;

            if (string.IsNullOrEmpty(tbSearch1.Text))
            {
                loadMemberTable(); return;
            }

            if (cbSearchBy1.Text == "Name")
            {
                query += " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search";
            }
            else if (cbSearchBy1.Text == "ID")
            {
                if (!int.TryParse(tbSearch1.Text, out int id))
                {               
                    return;
                }
                query += " AND member_id = @search";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy1.Text == "Name")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy1.Text == "ID")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMember.DataSource = dt;

        }

        private void tbSearch2_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT book_id as [Book ID], title as [Title], author as [Author], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0";
            string search = tbSearch2.Text;

            if (string.IsNullOrEmpty(tbSearch2.Text))
            {
                loadBookTable(); return;
            }

            if (cbSearchBy2.Text == "Title")
            {
                query += " AND title LIKE @search";
            }
            else if (cbSearchBy2.Text == "Author")
            {
                query += " AND author LIKE @search";
            }
            else if (cbSearchBy2.Text == "ISBN")
            {
                query += " AND isbn = @search";
            }
            else if (cbSearchBy2.Text == "ID")
            {
                query += " AND book_id = @search";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cbSearchBy2.Text == "Title")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy2.Text == "Author")
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else if (cbSearchBy2.Text == "ISBN")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            else if (cbSearchBy2.Text == "ID")
            {
                cmd.Parameters.AddWithValue("@search", search);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBook.DataSource = dt;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
