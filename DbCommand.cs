using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ElevatorController
{
    class DbCommand
    {
        // Save action logs into MySQL
        public void SaveLog(string act)
        {
            if (GlobalConnection.con == null || GlobalConnection.con.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open. Call GlobalConnection.DbConnection() first.");
            }

            string sql = "INSERT INTO ActionLogs(Date, Time, Actions) VALUES(@DATE, @TIME, @ACTIONS)";
            using (MySqlCommand cmd = new MySqlCommand(sql, GlobalConnection.con))
            {
                cmd.Parameters.AddWithValue("@DATE", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@TIME", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("@ACTIONS", act);

                cmd.ExecuteNonQuery();
            }
        }

        // Retrieve action logs from MySQL
        public DataTable ViewActionLog()
        {
            if (GlobalConnection.con == null || GlobalConnection.con.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open. Call GlobalConnection.DbConnection() first.");
            }

            string sql = "SELECT * FROM ActionLogs ORDER BY ID DESC";
            using (MySqlDataAdapter da = new MySqlDataAdapter(sql, GlobalConnection.con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "ActionLogs");
                return ds.Tables[0];
            }
        }

        // Delete all logs from MySQL
        public void DeleteAllLogs()
        {
            if (GlobalConnection.con == null || GlobalConnection.con.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open. Call GlobalConnection.DbConnection() first.");
            }

            string sql = "DELETE FROM ActionLogs";
            using (MySqlCommand cmd = new MySqlCommand(sql, GlobalConnection.con))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}