using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class DBManager
    {
        DBConnection connection = new DBConnection();

        public void AddCustomer(/*TODO: pass params here - or pass in customer object*/ string countryName, string cityName)
        {
            
            connection.InitConnection();


            //int cityId = GetCityId(cityName);
            int countryId = GetCountryId(countryName);

            string selectCity = "SELECT cityId" + " FROM city WHERE city = @cityName";

            MySqlCommand cmd = new MySqlCommand(selectCity, connection.GetConnection());
            cmd.Parameters.AddWithValue("@cityName", cityName);


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
