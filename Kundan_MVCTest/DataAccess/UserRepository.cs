using Kundan_MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Kundan_MVCTest.DataAccess
{
    public class UserRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Kundanconnection"].ToString();
        public List<UserModel> GetUsers(string firstName = "",string email="")
        {
            List<UserModel> users = new List<UserModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserMaster WHERE 1=1";
                if (!string.IsNullOrEmpty(firstName))
                    query += " AND FirstName LIKE @FirstName";
                if (!string.IsNullOrEmpty(email))
                    query += " AND Emailld LIKE @Email";

                SqlCommand cmd = new SqlCommand(query, con);
                if (!string.IsNullOrEmpty(firstName))
                    cmd.Parameters.AddWithValue("@FirstName", "%" + firstName + "%");
                if (!string.IsNullOrEmpty(email))
                    cmd.Parameters.AddWithValue("@Email", "%" + email + "%");

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();    
                
                        while (rdr.Read())
                        {
                            users.Add(new UserModel
                            {
                                ID = Convert.ToInt32(rdr["ID"]),
                                FirstName = rdr["FirstName"].ToString(),
                                MiddleName = rdr["MiddleName"].ToString(),
                                LastName = rdr["LastName"].ToString(),
                                EmailId = rdr["EmailId"].ToString(),
                                UserName = rdr["UserName"].ToString(),
                                BirthDate = Convert.ToDateTime(rdr["BirthDate"])
                            });
                        }
                    
            }
            return users;
        }   
    }
}