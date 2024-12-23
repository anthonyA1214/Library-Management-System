using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management_System.Classes
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Role { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleted { get; set; } 

        public Staff(int staffId ,string firstName, string lastName, string username, string password, string email, string contactNumber, string role, bool isApproved, bool isDeleted)
        {
            StaffId = staffId;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Email = email;
            ContactNumber = contactNumber;
            Role = role;
            IsApproved = isApproved;
            IsDeleted = isDeleted;
        }
    }

    public class manageStaffs
    {
        public bool AddStaff(Staff staff)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = "INSERT INTO tbl_staff (first_name, last_name, username, password, email, contact_number, role, IsApproved, IsDeleted) VALUES(@firstname, @lastname, @username, @password, @email, @contactnumber, @role, @isApproved, @isDeleted)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@firstname", staff.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", staff.LastName);
                    cmd.Parameters.AddWithValue("@username", staff.Username);
                    cmd.Parameters.AddWithValue("@password", staff.Password);
                    cmd.Parameters.AddWithValue("@email", staff.Email);
                    cmd.Parameters.AddWithValue("@contactnumber", staff.ContactNumber);
                    cmd.Parameters.AddWithValue("@role", staff.Role);
                    cmd.Parameters.AddWithValue("@isApproved", staff.IsApproved);
                    cmd.Parameters.AddWithValue("@isDeleted", staff.IsDeleted);
                    int checkrow = cmd.ExecuteNonQuery();
                    return checkrow > 0;
                }
            }       
        }

        public bool UpdateStaff(Staff staff)
        {
            string query = "UPDATE tbl_staff SET first_name = @firstname, last_name = @lastname, password = @password, contact_number = @contactnumber, role = @role WHERE staff_id = @staffid";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@staffid", staff.StaffId);
                    cmd.Parameters.AddWithValue("@firstname", staff.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", staff.LastName);
                    cmd.Parameters.AddWithValue("@username", staff.Username);
                    cmd.Parameters.AddWithValue("@password", staff.Password);
                    cmd.Parameters.AddWithValue("@email", staff.Email);
                    cmd.Parameters.AddWithValue("@contactnumber", staff.ContactNumber);
                    cmd.Parameters.AddWithValue("@role", staff.Role);
                    cmd.Parameters.AddWithValue("@isApproved", staff.IsApproved);
                    cmd.Parameters.AddWithValue("@isDeleted", staff.IsDeleted);
                    int checkrow = cmd.ExecuteNonQuery();
                    return checkrow > 0;
                }
            }
        }
    }
}
