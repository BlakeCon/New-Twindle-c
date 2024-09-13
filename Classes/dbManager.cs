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

        public dbManagerClass()
        {
            connectionString = "Data Source=localhost;Initial Catalog=newTwindleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Initialize the connection string here
        }

        public string currentUser;

        public bool CompareCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM MemberLogin WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        public (string, string, string) GetMemberInfo(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Username, MemberType, Id FROM MemberInfo WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string usrnameReturn = reader.GetString(0);
                string memberTypeReturn = reader.GetString(1);
                int idReturn = reader.GetInt32(2);
                connection.Close();

                return (usrnameReturn, memberTypeReturn, idReturn);
            }
        }

        //public (string, string, string) GetIdMemberInfo(string username)
        //{
           // using (SqlConnection connection = new SqlConnection(connectionString))
          //  {
             //   string query = "SELECT Username, MemberType, Id FROM MemberInfo WHERE Username = @Username";
             //   SqlCommand command = new SqlCommand(query, connection);
             //   command.Parameters.AddWithValue("@Username", username);

             //   connection.Open();
             //   SqlDataReader reader = command.ExecuteReader();
             //   reader.Read();
             //   string usrnameReturn = reader.GetString(0);
             //   string memberTypeReturn = reader.GetString(1);
             //   string idReturn = reader.GetString(2);
             //  connection.Close();

             //  return (usrnameReturn, memberTypeReturn, idReturn);
            //}
        //}

        public List<List<string>> GetEvents()
        {
            List<List<string>> events = new List<List<string>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Events";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

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

    }
}
