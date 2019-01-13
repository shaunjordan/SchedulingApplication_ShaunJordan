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

            MySqlDataReader reader = uCmd.ExecuteReader();
            
            while (reader.Read())
            {
                User.displayName = reader[1].ToString();
                valid += 1;
            }
            reader.Close();
            reader.Dispose();


            MySqlCommand pCmd = new MySqlCommand(checkPassword, conn.GetConnection());
            pCmd.Parameters.AddWithValue("@userName", userName);
            pCmd.Parameters.AddWithValue("@password", password);

            if (Convert.ToInt32(pCmd.ExecuteScalar()) > 0)
            {
                valid += 1;
                pCmd.Dispose();
            }

            conn.CloseConnection();
            return valid;
            
        }

        
    }
}
