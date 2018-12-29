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

        public void AddCustomer(/*TODO: pass params here - or pass in customer object*/ string countryName)
        {
            
            connection.InitConnection();


            //int cityId = GetCityId(cityName);
            int countryId = GetCountryId(countryName);
            //int cityId = GetCityId(cityName);

            //add new customer to DB

            MessageBox.Show(countryId.ToString());

            //string selectCity = "SELECT cityId" + " FROM city WHERE city = @cityName";

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
            string ctryRtn = "ins_ctry";
            int result;


                MySqlCommand cmd = new MySqlCommand(ctryRtn, connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ctry", countryName);

                result = Convert.ToInt32(cmd.ExecuteScalar());

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
