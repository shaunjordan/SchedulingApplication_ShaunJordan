﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace ClassLibrary
{
    public class DBManager
    {
                
        public void AddCustomer(string customerName, string address1, string address2, string cityName, string postalCode, string phone, string countryName, string createdBy, MySqlConnection conn)
        {
            //Retrieve the countryId based on name from a Stored Procedure
            int countryId = GetCountryId(countryName, conn);
            
            //Insert the city and retrieve the id from a Stored Procedure
            int cityId = GetCityId(cityName, countryId, createdBy, conn);

            //Insert the address and retrieve the id from a stored procedure
            int addressId = GetAddressId(address1, address2, cityId, postalCode, phone, createdBy, conn);


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

            addrId = Convert.ToInt32(cmd.Parameters["@addressId"].Value);

            return addrId;

        }

        private int GetCustomerId(string customerName, MySqlConnection conn)
        {
            int result;

            string select_customer = "select_customer";
         

            MySqlCommand cmd = new MySqlCommand(select_customer, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerName", customerName);

            result = Convert.ToInt32(cmd.ExecuteScalar());

            return result;

        }
              
        public void PopulateCustomerTable(MySqlConnection conn)
        {
            string select = "SELECT " +
                            "cust.customerId," +
                            "cust.customerName," +
                            "addr.address," +
                            "addr.address2," +
                            "city.city," +
                            "addr.postalcode," +
                            "addr.phone," +
                            "ctry.country " +
                            "FROM customer cust INNER JOIN address addr ON addr.addressId = cust.addressId " +
                            "INNER JOIN city ON city.cityId = addr.cityId " +
                            "INNER JOIN country ctry ON ctry.countryId = city.countryId " +
                            "ORDER BY cust.customerId ASC";

            MySqlCommand cmd = new MySqlCommand(select, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = Convert.ToInt32(reader[0]);
                    customer.CustomerName = reader[1].ToString();
                    customer.Address1 = reader[2].ToString();
                    customer.Address2 = reader[3].ToString();
                    customer.City = reader[4].ToString();
                    customer.PostalCode = reader[5].ToString();
                    customer.Phone = reader[6].ToString();
                    customer.Country = reader[7].ToString();


                    customer.AddCustomer(customer);

                }
            }

            reader.Close();
            reader.Dispose();
        }

        public bool DeleteCustomer(MySqlConnection conn, int customerId)
        {
            string delete_customer = "delete_customer";

            MySqlCommand cmd = new MySqlCommand(delete_customer, conn);
            cmd.Parameters.AddWithValue("@custId", customerId);
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //TODO: update method to bool or int
        public void UpdateCustomer(MySqlConnection conn, int customerId, string customerName, string address1, string address2, string cityName, string postal, string ctryName, string phone)
        {
            string update = "update_customer";

            MySqlCommand cmd = new MySqlCommand(update, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@custId", customerId);
            cmd.Parameters.AddWithValue("@custName", customerName);
            cmd.Parameters.AddWithValue("@addr1", address1);
            cmd.Parameters.AddWithValue("@addr2", address2);
            cmd.Parameters.AddWithValue("@postal", postal);
            cmd.Parameters.AddWithValue("@phNumber", phone);
            cmd.Parameters.AddWithValue("@cityName", cityName);
            cmd.Parameters.AddWithValue("@ctryId", GetCountryId(ctryName, conn));
            cmd.Parameters.AddWithValue("@lastUpdatedBy", User.displayName);

            int successfulUpdate = cmd.ExecuteNonQuery();

            if (successfulUpdate > 0)
            {
                MessageBox.Show("Customer updated.");
            }
            else
            {
                MessageBox.Show("Customer not updated.");
            }
            
        }

        public bool AddAppointment(string customer, string title, string descr, string location, string contact, string type, string url, string start, string end, MySqlConnection conn)
        {
            string insert_appointment = "insert_appointment";
            int custId = GetCustomerId(customer, conn);

            //int customer id = get the customer id of the item selected from the static list

            MySqlCommand cmd = new MySqlCommand(insert_appointment, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custId", custId);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@descr", descr);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@apptType", type);
            cmd.Parameters.AddWithValue("@url", url);
            cmd.Parameters.AddWithValue("@startTime", start);
            cmd.Parameters.AddWithValue("@endTime", end);
            cmd.Parameters.AddWithValue("@createdBy", User.displayName);

            int successfulIns = cmd.ExecuteNonQuery();

            if (successfulIns == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            



            
        }

        
    }
}
