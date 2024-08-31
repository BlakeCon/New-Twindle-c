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

        public staffDbManager()
        {
            connectionString = "Data Source=localhost;Initial Catalog=newTwindleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Initialize the connection string here
        }

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

        public (string, string, bool, bool) GetStaffInfo(string ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Position, MakeEvents, SuperUser FROM StaffInfo WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", ID);

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
    }
}
