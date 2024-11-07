using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gym_c__thing.Classes
{
    internal class dbManagerClass
    {
        private string connectionString;

        //Defines the connection string to the databas and initializes it so it is not repeated in every method.
        public dbManagerClass()
        {
            connectionString = "Data Source=localhost;Initial Catalog=newTwindleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Initialize the connection string here
        }

        //Compares the credentials of the user to the database, checkes to make sure there is one user with the username and password
        public bool CompareCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Counting the number of users with the username and password passed from the login form. 
                string query = "SELECT COUNT(*) FROM MemberLogin WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                //This returns true if the count is greater than 0, meaning there is a user with the username and password.
                return count > 0;
            }
        }

        //Returns the username, memberType, email, name and id of the member using the username
        public (string, string, string, string, int) GetMemberInfoUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Selects the username, memberType, email, name and id of the member using the username from the MemberInfo table.
                string query = "SELECT Username, MemberType, Email, Name, Id FROM MemberInfo WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                //Opens connections, reads the data and gives each value to a variable to be returned.
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string usrnameReturn = reader.GetString(0);
                string memberTypeReturn = reader.GetString(1);
                //If the email is null, it will return "Email not available" instead of null, same for name. If it is not null, it will return the email and name.
                string emailReturn = reader.IsDBNull(2) ? "Email not available" : reader.GetString(2);
                string nameReturn = reader.IsDBNull(3) ? "Name not available" : reader.GetString(3);
                int idReturn = reader.GetInt32(4);
                connection.Close();

                return (usrnameReturn, memberTypeReturn, emailReturn, nameReturn, idReturn);
            }
        }

        //Returns the username, memberType, email, name and id of the member using the id
        public (string, string, string, string, int) GetMemberInfoId(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Username, MemberType, Email, Name, Id FROM MemberInfo WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string usrnameReturn = reader.GetString(0);
                string memberTypeReturn = reader.GetString(1);
                string emailReturn = reader.GetString(2);
                string nameReturn = reader.GetString(3);
                int idReturn = reader.GetInt32(4);
                connection.Close();

                return (usrnameReturn, memberTypeReturn, emailReturn, nameReturn, idReturn);
            }
        }

        //Returns the username, memberType, email, name and id of the member using the name
        public (string, string, string, string, int) GetMemberInfoName(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Username, MemberType, Email, Name, Id FROM MemberInfo WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string usrnameReturn = reader.GetString(0);
                string memberTypeReturn = reader.GetString(1);
                string emailReturn = reader.GetString(2);
                string nameReturn = reader.GetString(3);
                int idReturn = reader.GetInt32(4);
                connection.Close();

                return (usrnameReturn, memberTypeReturn, emailReturn, nameReturn, idReturn);
            }
        }

        //Returns the events from the database in a list.
        public List<List<string>> GetEvents()
        {
            //Creates a list of lists to store the events.
            List<List<string>> events = new List<List<string>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Selects all the data from the Events table.
                string query = "SELECT * FROM Events";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //For each event, it will add the data to a list and then add that list to the events list.
                while (reader.Read())
                {
                    List<string> eventData = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (!reader.IsDBNull(i))
                        {
                            eventData.Add(reader[i].ToString());
                        }
                        else
                        //If the data is null, it will add an empty string to the list instead of null.
                        {
                            eventData.Add(string.Empty);
                        }
                    }
                    events.Add(eventData);
                }
                connection.Close();
            }
            return events;
        }

        //Returns the opening and closing hours of the gym on a given day.
        public (string, string) getHours(string day)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Selects the opening and closing time of the gym on the given day from the HoursOfOperation table.
                string query = "SELECT OpeningTime, ClosingTime FROM HoursOfOperation WHERE Day = @day";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@day", day);
                connection.Open();

                //Stores the opening and closing time of the gym in a tuple to be returned.
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string openingTime = reader.GetString(0);
                string closingTime = reader.GetString(1);
                connection.Close();
                return (openingTime, closingTime);
            }
        }
    }

    
}
