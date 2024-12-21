using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Resources
{
    public class AuthenticateUserResult
    {
        public string role { get; set; }
        public string message { get; set; }
        public bool isSuccessful { get; set; }
    }

    public class AuthenticateUser
    {
        public AuthenticateUserResult authenticateUser(string username, string password)
        {
            AuthenticateUserResult result = new AuthenticateUserResult();

            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT role, IsDeleted, IsApproved from tbl_staff WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {                    
                        bool isDeleted = Convert.ToBoolean(dr["IsDeleted"]);
                        bool isApproved = Convert.ToBoolean(dr["IsApproved"]);

                        if (!isApproved)
                        {
                            result.message = "Your account is not approved yet.";
                            result.isSuccessful = false;                            
                            return result;
                        }

                        if (isDeleted)
                        {
                            result.message = "Incorrect username or password.";
                            result.isSuccessful = false;
                            return result;
                        }

                        result.isSuccessful = true;
                        result.role = dr["role"].ToString().ToLower().Trim();
                    }
                    else
                    {
                        result.message = "Incorrect username or password.";
                        result.isSuccessful = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.isSuccessful = false;
                result.message = "An error occurred: " + ex.Message;
            }

            return result;
        }
    }
}
