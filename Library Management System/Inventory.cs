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
    public partial class Inventory : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECM8IVK\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;");

        public Inventory()
        {
            InitializeComponent();
        }

        private void pbHideShow_Click(object sender, EventArgs e)
        {
            if (pnlLowStocks.Height == 200)
            {
                pnlLowStocks.Height = 35;
                pnlLowStocksContainer.Height = 55;
                pbHideShow.Image = Properties.Resources.down_arrow;
            }
            else
            {
                pnlLowStocks.Height = 200;
                pnlLowStocksContainer.Height = 220;
                pbHideShow.Image = Properties.Resources.up_arrow;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT author from tbl_book";
            string query2 = "SELECT genre from tbl_book";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();         
            while (dr1.Read())
            {
                string author = dr1[0].ToString();

                if (!cbSearchAuthor.Items.Contains(author))
                {
                    cbSearchAuthor.Items.Add(author);
                }
            }
            dr1.Close();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string genre = dr2[0].ToString();

                if (!cbSearchGenre.Items.Contains(genre))
                {
                    cbSearchGenre.Items.Add(genre);
                }
            }
            dr2.Close();
            conn.Close();
        }
    }
}
