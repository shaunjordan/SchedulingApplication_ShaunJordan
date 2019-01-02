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
        
        public void AddCustomer(string customerName, string address1, string address2, string cityName, string postalCode, string phone, string countryName, string createdBy, MySqlConnection conn)
        {

            int countryId = GetCountryId(countryName, conn);
            
            int cityId = GetCityId(cityName, countryId, createdBy, conn);

            int addressId = GetAddressId(address1, address2, cityId, postalCode, phone, createdBy, conn);


            //InsertCustomer(customerName, addressId, createdBy, conn);


            //add new customer to DB

            //MessageBox.Show(countryId.ToString());

            string add_customer = "insert_customer";

            MySqlCommand cmd = new MySqlCommand(add_customer, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerName", customerName);
            cmd.Parameters.AddWithValue("@addressId", addressId);
            cmd.Parameters.AddWithValue("@createdBy", createdBy);
            
            int successfulIns = cmd.ExecuteNonQuery();

            if (successfulIns == 1)
            {
                MessageBox.Show("Customer successfully added to the database.");
            }
            else
            {
                MessageBox.Show("Error adding customer to database.");
            }

            //connection.CloseConnection();
        }

        private int GetCountryId(string countryName, MySqlConnection conn)
        {
            //TODO: connection is init in AddCustomer does it need to be added here as well? or passed into this param?
            string ctryRtn = "select_country";

            int result;


            MySqlCommand cmd = new MySqlCommand(ctryRtn, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ctry", countryName);

            result = Convert.ToInt32(cmd.ExecuteScalar());

            return result;

        }

        private int GetCityId(string cityName, int countryId, string createdBy, MySqlConnection conn)
        {
            //TODO: pass the user name into here
            //TODO: wrap up everything in a using statements
            string cityRtn = "insert_city";
            int cid;

            MySqlCommand cmd = new MySqlCommand(cityRtn, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cityName", cityName);
            cmd.Parameters.AddWithValue("@countryId", countryId);
            cmd.Parameters.AddWithValue("@createdBy", createdBy);

            cmd.Parameters.AddWithValue("@cityId", MySqlDbType.Int32);
            cmd.Parameters["@cityId"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            cid = Convert.ToInt32(cmd.Parameters["@cityId"].Value); //TODO: get the OUT param from the procedure

            return cid;

        }

        private int GetAddressId(string address1, string address2, int cityId, string postalCode, string phone, string createdBy, MySqlConnection conn)
        {
            string addrRtn = "insert_address";
            int addrId;

            MySqlCommand cmd = new MySqlCommand(addrRtn, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@address1", address1);
            cmd.Parameters.AddWithValue("@address2", address2);
            cmd.Parameters.AddWithValue("@cityId", cityId);
            cmd.Parameters.AddWithValue("@postalCode", postalCode);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@createdBy", createdBy);

            cmd.Parameters.AddWithValue("@addressId", MySqlDbType.Int32);
            cmd.Parameters["@addressId"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            addrId = Convert.ToInt32(cmd.Parameters["@cityId"].Value);

            return addrId;

        }

        private void InsertCustomer(string customerName, int addressId, string createdBy, MySqlConnection conn)
        {
            string add_customer = "insert_customer";

            MySqlCommand cmd = new MySqlCommand(add_customer, conn);
            cmd.Parameters.AddWithValue("@customerName", customerName);
            cmd.Parameters.AddWithValue("@addressId", addressId);
            cmd.Parameters.AddWithValue("@createdBy", createdBy);

            int successfulIns = cmd.ExecuteNonQuery();

            if (successfulIns == 1)
            {
                MessageBox.Show("Customer successfully added to the database.");
            }
            else
            {
                MessageBox.Show("Error adding customer to database.");
            }
        }
    }
}
