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
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            

            //customer.CustomerId auto increment the id
            customer.CustomerName = custNameTextBox.Text;
            customer.Address1 = addressLine1.Text;
            customer.Address2 = addressLine2.Text;
            customer.City = cityTextBox.Text;
            customer.PostalCode = postalCodeTextbox.Text;
            customer.Country = countryTextBox.Text;
            customer.Phone = phoneTextBox.Text;

            customer.AddCustomer(customer);
           
            //code in the SQL insertinto
            //addr1, addr2, and phone part of the same table
            
        }
    }
}
