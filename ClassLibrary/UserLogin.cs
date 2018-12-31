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
                conn.CloseConnection();
                dataAdapter.Dispose();
                return true;
            }
            else
            {
                return false;
            }
            

        }

        public bool ValidateLogin(string userName, string password)
        {

            DBConnection conn = new DBConnection();

            conn.InitConnection();

            //TODO: split off the userName and password for individualized error messages

            string loginQuery = "SELECT userId, userName " + "FROM user WHERE userName = @userName AND password = @password";

            MySqlCommand cmd = new MySqlCommand(loginQuery, conn.GetConnection());

            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }

            //try
            //{
            //    User validUser = new User();

            //    while (reader.Read())
            //    {
            //        validUser.UserId = Convert.ToInt32(reader[0]);
            //        validUser.UserName = reader[1].ToString();

            //        User.displayName = reader[1].ToString();
                    
            //    }
                                        

            //    reader.Close();
            //    reader.Dispose();
            //    conn.CloseConnection();

            //    return validUser;
                
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }
        
    }
}
