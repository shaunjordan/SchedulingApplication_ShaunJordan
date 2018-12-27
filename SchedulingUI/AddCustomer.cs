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

            //DBConnection connection = new DBConnection();
            //connection.InitConnection();


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
            //connection.CloseConnection();

        }

        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            
            connection.InitConnection();

            string select = "SELECT countryId" + " FROM city WHERE city = @cityName;";
            

            MySqlCommand cmd = new MySqlCommand(select, connection.GetConnection());
            cmd.Parameters.AddWithValue("@cityName", cityTextBox.Text);

            //MySqlDataReader reader = cmd.ExecuteReader();

            int result = Convert.ToInt32(cmd.ExecuteScalar());

            MessageBox.Show(result.ToString());

            connection.CloseConnection();

        }
    }
}
