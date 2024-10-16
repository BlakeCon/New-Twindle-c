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


        //Defines the connection string to the databas and initializes it so it is not repeated in every method.
        public dbRegistrationManager()
        {
            connectionString = "Data Source=localhost;Initial Catalog=newTwindleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Initialize the connection string here
        }


        //Gets the latest ID from the MemberInfo table
        public int getLatestID()
            {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Selects the highest ID from the MemberInfo table
                string query = "SELECT MAX(Id) FROM MemberInfo";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                //selected data is stored in latestID variable and returned.
                int latestID = (int)command.ExecuteScalar();
                connection.Close();

                return latestID;
            }
        }

        //Checks if the username already exists in the database by counting the number of users with the username.
        public bool UsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Selects the number of users with the username passed from the registration form.
                string query = "SELECT COUNT(*) FROM MemberLogin WHERE Username = @username";
                SqlCommand command = new SqlCommand(query,connection);
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", username);
                    
                    //Saves the count as a result
                    int result = (int)command.ExecuteScalar();
                    connection.Close();

                    //If the result is 0, it will return false, meaning the username does not exist. If it is greater than 0, it will return true, meaning the username exists.
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
                    //If an error occurs, it will show a message box with the error message and return true (to prevent the user from registering)
                    MessageBox.Show("An error has occured with the database: ", ex.Message);
                    return true;
                }

            }
        }

        //Registers the user by inserting the username, memberType, email and password into the MemberInfo and MemberLogin tables.
        public bool RegisterUser(string username, string email, string password, string memberType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                //If the username already exists, it will show a message box and return false showing that the user cannot be registered.
                if(UsernameExists(username)) 
                {
                    MessageBox.Show("Username already exists!");
                    return false;
                }

                //Gets the latest ID from the MemberInfo table and increments it by 1 to get the new ID for the user.
                int latestID = getLatestID();
                latestID = latestID + 1;
                //Defining the querys to insert the data into the the respective tables.
                string query1 = "INSERT INTO MemberInfo (Id, Username, MemberType, Email) VALUES (@memberID, @username, @memberType, @Email)";
                string query2 = "INSERT INTO MemberLogin (Id, Username, Password) VALUES (@memberID, @username, @password)";
                SqlCommand command1 = new SqlCommand(query1, connection);
                SqlCommand command2 = new SqlCommand(query2, connection);
                
                //Adding the parameters to the querys and executes the two queries to insert the data into the tables.
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
