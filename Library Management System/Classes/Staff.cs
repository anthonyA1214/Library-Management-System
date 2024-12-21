using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Classes
{
    public class Staff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Role { get; set; }
        public bool IsApproved { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public Staff(string firstName, string lastName, string username, string password, string email, string contactNumber, string role, bool isApproved, bool isDeleted)
        {
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
        public void AddStaff(Staff staff)
        {
            string query = "INSERT INTO tbl_staff (first_name, last_name, username, password, email, contact_number, role, IsApproved, IsDeleted) VALUES(@firstname, @lastname, @username, @password, @email, @contactnumber, @role, @isApproved, @isDeleted)";
            
        }

    }
}
