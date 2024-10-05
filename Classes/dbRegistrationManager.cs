using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gym_c__thing.Classes
{
    internal class dbRegistrationManager
    {
        private string connectionString;

        public dbRegistrationManager()
        {
            connectionString = "Data Source=localhost;Initial Catalog=newTwindleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Initialize the connection string here
        }

        public int getLatestID()
            {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Id) FROM MemberInfo";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int latestID = (int)command.ExecuteScalar();
                connection.Close();

                return latestID;
            }
        }

        public bool UsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM MemberLogin WHERE Username = @username";
                SqlCommand command = new SqlCommand(query,connection);
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", username);
                    int result = (int)command.ExecuteScalar();
                    connection.Close();
                    if (result == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured with the database: ", ex.Message);
                    return true;
                }

            }
        }

        public bool RegisterUser(string username, string email, string password, string memberType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                if(UsernameExists(username)) 
                {
                    MessageBox.Show("Username already exists!");
                    return false;
                }

                int latestID = getLatestID();
                latestID = latestID + 1;
                string query1 = "INSERT INTO MemberInfo (Id, Username, MemberType, Email) VALUES (@memberID, @username, @memberType, @Email)";
                string query2 = "INSERT INTO MemberLogin (Id, Username, Password) VALUES (@memberID, @username, @password)";
                SqlCommand command1 = new SqlCommand(query1, connection);
                SqlCommand command2 = new SqlCommand(query2, connection);
                
                try
                    {
                    connection.Open();
                    command1.Parameters.AddWithValue("@memberID", latestID);
                    command1.Parameters.AddWithValue("@username", username);
                    command1.Parameters.AddWithValue("@memberType", memberType);
                    command1.Parameters.AddWithValue("@Email", email);
                    command2.Parameters.AddWithValue("@memberID", latestID);
                    command2.Parameters.AddWithValue("@username", username);
                    command2.Parameters.AddWithValue("@password", password);
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured with uploading the data: ", e.Message);
                    return false;
                }
            }
        }
    }
}
