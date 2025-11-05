using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ElevatorController
{
    class GlobalConnection
    {
        public static MySqlConnection con;

        public static void DbConnection()
        {
            try
            {
                // Use relative path for portability
                string projectPath = Application.StartupPath;

                // MySQl Connection setup
                string connectionString = "server=127.0.0.1;port=3316;database=elevatordb;user=root;password=12345;";

                con = new MySqlConnection(connectionString);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                Console.WriteLine("MySQL Connection Successful!");

                // Create table if it doesn't exist
                CreateTableIfNotExists();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error connecting to MySQL: " + ex.Message +
                    "\n\nPlease ensure:\n" +
                    "1. MySQL server is running\n" +
                    "2. Database 'elevatordb' exists\n" +
                    "3. Credentials are correct\n" +
                    "4. Port number is correct (3306 or 3316)",
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                throw;
            }
        }

        private static void CreateTableIfNotExists()
        {
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS ActionLogs (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Date VARCHAR(50),
                    Time VARCHAR(50),
                    Actions VARCHAR(255)
                )";

            using (MySqlCommand cmd = new MySqlCommand(createTableQuery, con))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
                Console.WriteLine("MySQL Connection Closed!");
            }
        }
    }
}