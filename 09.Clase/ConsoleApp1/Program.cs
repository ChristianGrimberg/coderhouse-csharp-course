using System.Data.SqlClient;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Server=.; Database=SistemaGestion; User=sa; Password=P@ssw0rd;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Usuario;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            var data = dataReader.GetString(1);
                            Console.WriteLine(data);
                        }
                    }
                }
            }

            connection.Close();
        }
    }
}
