using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace ClassLibrary
{
    public class UserLogin
    {
        public int ValidLogin(string userName, string password)
        {

            DBConnection conn = new DBConnection();
                                   
            string loginQuery = "SELECT * FROM user WHERE userName = '"+userName+"' AND password = '"+password+"'";
            
            DataTable results = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(loginQuery, conn.InitConnection());

            dataAdapter.Fill(results);

            int rowCount = Convert.ToInt32(results.Rows.Count.ToString());

            //TODO: try statements and develop messages class to take a delegate?
                      

            conn.CloseConnection();
            return rowCount;
        }
        
    }
}
