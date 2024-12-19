using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Library_Management_System
{
    internal class dbConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=NHETTEFELICES04\\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
