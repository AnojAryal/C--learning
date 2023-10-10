using System;
using MySqlConnector;

namespace ADO_NET.V2
{
    internal class MyDatabase
    {
        private MySqlConnection conn = null;
        private string url = "datasource=localhost; database=Week5secB; port=3306; User=root; Password=fastrack";
        public MySqlConnection Connect()
        {
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return conn;
        }
        public bool Close(MySqlConnection conn)
        {
            bool result = false;
            try
            {
                conn.Close();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}

