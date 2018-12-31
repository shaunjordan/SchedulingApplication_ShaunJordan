using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class DBManager
    {
        DBConnection connection = new DBConnection();

        public void AddCustomer(string customerName, string address1, string address2, string cityName, string postalCode, string countryName, string phone, string user)
        {
            
            connection.InitConnection();


            //int cityId = GetCityId(cityName);
            int countryId = GetCountryId(countryName);

            int cityId = GetCityId(cityName, countryId);

            int addressId = GetAddressId(address1, address2, cityId, postalCode, phone);



            //add new customer to DB

            MessageBox.Show(countryId.ToString());

            string add_customer = "insert_customer";

            MySqlCommand cmd = new MySqlCommand(add_customer, connection.GetConnection());
            cmd.Parameters.AddWithValue("@customerName", customerName);
            cmd.Parameters.AddWithValue("@addressId", cityId);
            cmd.Parameters.AddWithValue("@createdBy", user);


            //MySqlCommand cmd = new MySqlCommand(selectCity, connection.GetConnection());
            //cmd.Parameters.AddWithValue("@cityName", cityName);


            //MySqlDataReader reader = cmd.ExecuteReader();
            //int result = Convert.ToInt32(cmd.ExecuteScalar());

            //if (result > 0)
            //{
            //    cityId = Convert.ToInt32(reader[0]);
            //}
            //else
            //{
            //    //cityId = GenerateCityId();
            //}   

            connection.CloseConnection();
        }

        private int GetCountryId(string countryName)
        {
            //TODO: connection is init in AddCustomer does it need to be added here as well? or passed into this param?
            string ctryRtn = "select_ctry";
            int result;


                MySqlCommand cmd = new MySqlCommand(ctryRtn, connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ctry", countryName);

                result = Convert.ToInt32(cmd.ExecuteScalar());

                return result;
                                
        }

        private int GetCityId(string cityName, int countryId)
        {
            string cityRtn = "select_city";
            int result;

            MySqlCommand cmd = new MySqlCommand(cityRtn, connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cityName", cityName);
            cmd.Parameters.AddWithValue("@countryId", countryId);

            result = 1; //TODO: get the OUT param from the procedure

            return result;

        }

        private int GetAddressId(string address1, string address2, int cityId, string postalCode, string phone)
        {
            string addrRtn = "select_address";
            int result;

            MySqlCommand cmd = new MySqlCommand(addrRtn, connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@address1", address1);
            cmd.Parameters.AddWithValue("@address2", address2);
            cmd.Parameters.AddWithValue("@cityId", cityId);
            cmd.Parameters.AddWithValue("@postalCode", postalCode);

            result = 1;

            return result;




        } 

        //public int GetCityId(string cityName)
        //{
        //    string selectCityId = "SELECT cityId" + "FROM city WHERE city = @cityName";
        //    int result;

        //    using (MySqlCommand cmd = new MySqlCommand(selectCityId, connection.GetConnection()))
        //    {
        //        cmd.Parameters.AddWithValue("@cityName", cityName);
        //        result = Convert.ToInt32(cmd.ExecuteScalar());

        //        if (result > 0)
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            string insertNewCity = "SELECT cityId" + "FROM city WHERE city = @cityName";
        //            using (resource)
        //            {

        //            }
        //            return result;
        //        }
        //    } 
        //}


    }
}
