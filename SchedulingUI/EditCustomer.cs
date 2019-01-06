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
    public partial class EditCustomer : Form
    {
        //New DB connection called here because edit form needs its own
        //instead of allowing the edit button to open and close the connection
        DBConnection connection = new DBConnection();

        DBManager manager = new DBManager();

        private int customerId;

        public EditCustomer(int custId)
        {
            InitializeComponent();

            customerId = custId;

            connection.InitConnection();
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
                            "WHERE cust.customerId = @custId";

            MySqlCommand cmd = new MySqlCommand(select, connection.GetConnection());
            cmd.Parameters.AddWithValue("@custId", custId);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {
                    editCustNameTextbox.Text = reader[1].ToString();
                    editAddr1Textbox.Text = reader[2].ToString();
                    editAddr2Textbox.Text = reader[3].ToString();
                    editCityTextbox.Text = reader[4].ToString();
                    editPostalTextbox.Text = reader[5].ToString();
                    editPhoneTextbox.Text = reader[6].ToString();
                    editCountrySelectBox.Text = reader[7].ToString();
                }
            }

            reader.Close();
            reader.Dispose();
            connection.CloseConnection();
        }

        private void saveEditCustBtn_Click(object sender, EventArgs e)
        {
            connection.InitConnection();
            //string customerName, string address1, string address2, string cityName, string postal, string ctryName, string phone

            string customerName = editCustNameTextbox.Text;
            string address1 = editAddr1Textbox.Text;
            string address2 = editAddr2Textbox.Text;
            string cityName = editCityTextbox.Text;
            string postalCode = editPostalTextbox.Text;
            string phone = editPhoneTextbox.Text;
            string country = editCountrySelectBox.Text;

            manager.UpdateCustomer(connection.GetConnection(), customerId, customerName, address1, address2, cityName, postalCode, country, phone);

            connection.CloseConnection();
            this.Close();
        }

        private void cancelEditCustBtn_Click(object sender, EventArgs e)
        {
            //TODO: are you sure you want to cancel? Changes will not be saved
            this.Close();
        }
    }
}
