using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace SchedulingClassLibrary
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string databaseName;
        private string user;
        private string password;
        private string connectionString;

        public void InitConnection()
        {
            server = "52.206.157.109";
            databaseName = "U05Fdz";
            user = "U05Fdz";
            password = "53688484989";

            connectionString = String.Format("server={0}; database={1}; username={2}; password={3}", server, databaseName, user, password);

            connection = new MySqlConnection(connectionString);

            connection.Open(); //add System.Data as reference
        }

        private void Connection()
        {
            try
            {
                //connection.Open();

            }
            catch
            {

            }
        }
    }
}
