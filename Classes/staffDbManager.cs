using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gym_c__thing.Classes
{
    internal class staffDbManager
    {
        private string connectionString;

        //Defines the connection string to the databas and initializes it so it is not repeated in every method.
        public staffDbManager()
        {
            connectionString = "Data Source=localhost;Initial Catalog=newTwindleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Initialize the connection string here
        }

        //Compares the credentials of the staff member to the database.
        //This could just use the one in the dbManagerClass, but I wanted to keep them separate for now.
        public bool CompareCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM StaffLogin WHERE Id = @ID AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        //Returns the name, position, and permisions of the staff member using the staff ID
        public (string, string, bool, bool) GetStaffInfo(string ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Gets all relevent staff information from the database using the ID
                string query = "SELECT Name, Position, MakeEvents, SuperUser FROM StaffInfo WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", ID);

                //Reads the data and gives each value to a variable (Actually set to the correct datatypes too!) to be returned.
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string nameReturn = reader.GetString(0);
                string posReturn = reader.GetString(1);
                bool makeEventsReturn = reader.GetBoolean(2);
                bool superUserReturn = reader.GetBoolean(3);
                connection.Close();

                return (nameReturn, posReturn, makeEventsReturn, superUserReturn);
            }
        }

        //Honestly need to move this to a new events class, "but I'm lazy" - VS auto comment 2024
        public int getLatesEventID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Selects the highest ID from the Events table
                string query = "SELECT MAX(Id) FROM Events";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int latestID = (int)command.ExecuteScalar();
                connection.Close();

                return latestID;
            }
        }

        //Removes an event from the database using the event ID
        //Unsure if to move this to another class or leave it here because it is a staff function.
        public bool RemoveEvent(int Id) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Deletes the record from the Events table using the ID
                string query = "DELETE FROM Events WHERE Id = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", Id);

                connection.Open();
                //This count returns the number of rows affected by the query, NOT true or false. 
                int count = command.ExecuteNonQuery();
                connection.Close();

                //if more than 0 rows are affected, it will return true, meaning the event was removed.
                return count > 0;
            }
        }

        //Adds an event to the database using the event ID, name, info and expiry date as identifiers..
        //Unsure if to move this to another class or leave it here because it is a staff function.
        public bool AddEvent(int Id, string name, string info, string expiry) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Makes a new record to insert into the Events table using the ID, name, info and expiry date.
                string query = "INSERT INTO Events (Id, EventName, EventInfo, expiry) VALUES (@ID, @Name, @Info, @Expiry)";
                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@ID", Id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Info", info);
                command.Parameters.AddWithValue("@Expiry", expiry);
                
                connection.Open();
                //This count returns the number of rows affected by the query, NOT true or false.
                int count = command.ExecuteNonQuery();
                connection.Close();
                //if more than 0 rows are affected, it will return true, meaning the event was added.
                return count > 0;

            }
        }
    }
}
