using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace ClassLibrary
{
    public class UserLogin
    {
        public bool Login(string userName, string password)
        {

            DBConnection conn = new DBConnection();
            DataTable results = new DataTable();

            conn.InitConnection();

            string loginQuery = "SELECT * " + "FROM user WHERE userName = @userName AND " + "password = @password";


            MySqlCommand cmd = new MySqlCommand(loginQuery, conn.GetConnection());
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
                       
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = cmd;

            dataAdapter.Fill(results);
            int rowCount = Convert.ToInt32(results.Rows.Count.ToString());

            //TODO: try statements and develop messages class to take a delegate?
            //TODO: return and pass user id into main app
            if (rowCount > 0)
            {
                User.displayName = results.Rows[0][1].ToString();

                conn.CloseConnection();
                dataAdapter.Dispose();

                return true;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}
