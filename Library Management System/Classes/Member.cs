using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Classes
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string MembershipType { get; set; }

        public Member(int memberId, string firstName, string lastName, int age, string address, string contactNumber, string email, string membershipType)
        {
            MemberId = memberId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            ContactNumber = contactNumber;
            Email = email;
            MembershipType = membershipType;
        }
    }

    public class manageMembers
    {
        public bool AddMember(Member member)
        {
            string query = "INSERT into tbl_member(first_name,last_name,age,address,contact_number,email,membership_type) values(@firstname,@lastname,@age,@address,@contactnumber,@email,@membershiptype)";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstname", member.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", member.LastName);
                    cmd.Parameters.AddWithValue("@age", member.Age);
                    cmd.Parameters.AddWithValue("@address", member.Address);
                    cmd.Parameters.AddWithValue("@contactnumber", member.ContactNumber);
                    cmd.Parameters.AddWithValue("@email", member.Email);
                    cmd.Parameters.AddWithValue("@membershiptype", member.MembershipType);
                    int checkrow = cmd.ExecuteNonQuery();
                    return checkrow > 0;
                }
            }
        }

        public bool UpdateMember(Member member)
        {
            string query = "UPDATE tbl_member SET first_name = @firstname, last_name = @lastname, age = @age, address = @address, contact_number = @contactnumber, email = @email, membership_type = @membershiptype WHERE member_id = @memberid";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@memberid", member.MemberId);
                    cmd.Parameters.AddWithValue("@firstname", member.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", member.LastName);
                    cmd.Parameters.AddWithValue("@age", member.Age);
                    cmd.Parameters.AddWithValue("@address", member.Address);
                    cmd.Parameters.AddWithValue("@contactnumber", member.ContactNumber);
                    cmd.Parameters.AddWithValue("@email", member.Email);
                    cmd.Parameters.AddWithValue("@membershiptype", member.MembershipType);
                    int checkrow = cmd.ExecuteNonQuery();
                    return checkrow > 0;
                }
            }
        }
    }
}
