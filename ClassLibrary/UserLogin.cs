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
        
        public int Login(string userName, string password)
        {
            int valid = 0;

            DBConnection conn = new DBConnection();
            DataTable results = new DataTable();

            conn.InitConnection();

            string checkUser = "SELECT * " + "FROM user WHERE userName = @userName";
            string checkPassword = "SELECT * " + "FROM user WHERE userName = @userName AND " + "password = @password";

            MySqlCommand uCmd = new MySqlCommand(checkUser, conn.GetConnection());
            uCmd.Parameters.AddWithValue("@userName", userName);

            
            //TODO: implement unique constaint on DB to prevent duplicate user names
            if (Convert.ToInt32(uCmd.ExecuteScalar()) == 1) 
            {
                valid += 1;
                uCmd.Dispose();
            }


            MySqlCommand pCmd = new MySqlCommand(checkPassword, conn.GetConnection());
            pCmd.Parameters.AddWithValue("@userName", userName);
            pCmd.Parameters.AddWithValue("@password", password);

            if (Convert.ToInt32(pCmd.ExecuteScalar()) == 1)
            {
                valid += 1;
                pCmd.Dispose();
            }

            conn.CloseConnection();
            return valid;
            
        }

        
    }
}
