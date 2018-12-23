using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server = "52.206.157.109";
        private string databaseName = "U05Fdz";
        private string user = "U05Fdz";
        private string password = "53688484989";
        private string connectionString;

        public void InitConnection()
        {
            
            connectionString = String.Format("server={0}; database={1}; username={2}; password={3}", server, databaseName, user, password);

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                //MessageBox.Show("Connection open");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }

        }

        public MySqlConnection GetConnection()
        {
            return connection;
           
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        //private void Connection()
        //{
        //    try
        //    {
        //        connection.Open();
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
