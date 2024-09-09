using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiet_Attic_Film
{
    internal class DbConnection
    {
        private SqlConnection connection;
        public DbConnection() {
        }

        public void getConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source= NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");

            try
            {
                connection.Open();
                Console.WriteLine("Connection opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening connection: {ex.Message}");
                connection.Dispose();
                throw;
            }
        }

        public void CloseConnection(SqlConnection connection)
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
            Console.WriteLine("Connection closed successfully.");
        }
    }
    }
}
