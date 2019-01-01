using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using MySql.Data.MySqlClient;

namespace SchedulingUI
{
    public partial class AddCustomer : Form
    {

        DBConnection connection = new DBConnection();

        public AddCustomer()
        {
            InitializeComponent();
            
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {


            connection.InitConnection();


            string customerName = custNameTextBox.Text;
            string address1 = addressLine1.Text;
            string address2 = addressLine2.Text;
            string cityName = cityTextBox.Text;
            string postalCode = postalCodeTextbox.Text;
            string phone = phoneTextBox.Text;
            string country = countrySelectBox.Text;

            DBManager newCustomer = new DBManager();

            newCustomer.AddCustomer(customerName, address1, address2, cityName, postalCode, phone, country, User.displayName, connection.GetConnection());


            //Customer customer = new Customer();            

            ////customer.CustomerId auto increment the id
            //customer.CustomerName = custNameTextBox.Text;
            //customer.Address1 = addressLine1.Text;
            //customer.Address2 = addressLine2.Text;
            //customer.City = cityTextBox.Text;
            //customer.PostalCode = postalCodeTextbox.Text;
            //customer.Phone = phoneTextBox.Text;
            //customer.Country = countryTextBox.Text;

            //int countryId = 47;
            ////TODO: try here
            ////TODO: replace admin with user
            //string addCountry = "INSERT INTO country VALUES(" + countryId + ",'" + customer.Country  + "', current_timestamp(), 'admin', current_timestamp(), 'admin')";
            //MySqlCommand cmd = new MySqlCommand(addCountry, connection.GetConnection());
            //cmd.ExecuteNonQuery();

            //int countryId = Convert.ToInt32(cmd.LastInsertedId);

            //string addCity = "INSERT INTO city VALUES('0', '" + customer.City + "'," + countryId + "," + "current_timestamp(), 'admin', current_timestamp(), 'admin')";
            //cmd = new MySqlCommand(addCity, connection.GetConnection());

            //cmd.ExecuteNonQuery();

            //MessageBox.Show(cmd.LastInsertedId.ToString());

            //CustomerDatabase

            /*
             * insert into city
             * 
             * get the city id
             * 
             * insert into address
             * 
             * get the address id
             * 
             * insert into customer
             * 
             * 
             * 
             * */

            //code in the SQL insertinto
            //addr1, addr2, and phone part of the same table
            // insert into customer
            //customer id auto
            //customerName = customerNameTextBox.Text
            //customer.
            //conn.Close();
            connection.CloseConnection();

        }

        private void cancelCustBtn_Click(object sender, EventArgs e)
        {

            connection.InitConnection();

            //TODO: pass the user name into here
            //string cityRtn = "insert_city";

            //int countryId = 294;
            //string cityName = "St. Louis";
            //string createdBy = "test";

            ////int cid;

            ////MySqlCommand cmd = new MySqlCommand(cityRtn, connection.GetConnection());
            ////cmd.CommandType = CommandType.StoredProcedure;

            ////cmd.Parameters.AddWithValue("@cityName", cityName);
            ////cmd.Parameters.AddWithValue("@countryId", countryId);
            ////cmd.Parameters.AddWithValue("@createdBy", createdBy);

            ////cmd.Parameters.AddWithValue("@cId", MySqlDbType.Int32);
            ////cmd.Parameters["@cId"].Direction = ParameterDirection.Output;

            ////cid = Convert.ToInt32(cmd.Parameters["@cId"].Value); //TODO: get the OUT param from the procedure

            ////MessageBox.Show(cid.ToString());

            //string myNew = "mynew";
            //MySqlCommand cmd = new MySqlCommand(myNew, connection.GetConnection());
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@cityName", cityName);
            //cmd.Parameters.AddWithValue("@countryId", countryId);
            //cmd.Parameters.AddWithValue("@createdBy", createdBy);

            //cmd.ExecuteNonQuery();




            string country = "United States";
            string city = "Lubbock";
            string createdBy = "test";

            DBManager add = new DBManager();

            add.AddCustomer(country, city, createdBy, connection.GetConnection());


            //string ctrn = "select_country";

            ////TODO: update stored procedure

            //MySqlCommand cmd = new MySqlCommand(ctrn, connection.GetConnection());
            //cmd.Parameters.AddWithValue("@ctry", countrySelectBox.Text);

            //cmd.CommandType = CommandType.StoredProcedure;

            //int result = Convert.ToInt32(cmd.ExecuteScalar());

            //MessageBox.Show(result.ToString());


            //connection.CloseConnection();



        }
    }
}
