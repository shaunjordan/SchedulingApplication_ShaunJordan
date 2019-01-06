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
        //TODO: country list selection should come directly from Database for single source updating
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


            connection.CloseConnection();

            this.Close();

        }

        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            //TODO: are you sure you want to cancel?
            this.Close();

        }
    }
}
