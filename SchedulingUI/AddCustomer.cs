﻿using System;
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

        DBManager newCustomer = new DBManager();
               
               
        public AddCustomer()
        {
            InitializeComponent();

            countrySelectBox.SelectedIndex = 0;
            
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {


            connection.InitConnection();

            List<TextBox> requiredInputs = new List<TextBox> { custNameTextBox, addressLine1, cityTextBox, postalCodeTextbox, phoneTextBox };
            /*
             * Lamba used here to determine if any of the required textboxes are empty or contain only whitespace
             * If so the name of the textbox is pushed to a string to display in a message box along with some error text.
             * This is more efficient than using a for-loop to loop through the list of required textboxes and determine if they are empty:
             * to do so would require multiple lines of code, whereas the use of a lambda and some methods on the textboxes allows for the 
             * same to be accomplished in three lines of code.
             */
            var checkFields = requiredInputs.Where(input => String.IsNullOrWhiteSpace(input.Text))
                .Select(input => input.AccessibleName)
                .ToArray();

            var checkedFields = checkFields;

            if (checkedFields.Length > 0)
            {
                string InvalidFields = "";

                foreach (var inputName in checkedFields)
                {

                 InvalidFields += inputName + " cannot be blank.\n";

                }

                MessageBox.Show(InvalidFields.ToString(), "Invalid data in form");
                
            }
            else
            {
                string customerName = custNameTextBox.Text;
                string address1 = addressLine1.Text;
                string address2 = addressLine2.Text;
                string cityName = cityTextBox.Text;
                string postalCode = postalCodeTextbox.Text;
                string phone = phoneTextBox.Text;
                string country = countrySelectBox.Text;

                newCustomer.AddCustomer(customerName, address1, address2, cityName, postalCode, phone, country, User.displayName, connection.GetConnection());

                this.Close();
            }

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
                                  
            connection.CloseConnection();

            

        }

        private void ErrorAlert(string errors)
        {
            MessageBox.Show(errors);
        }

        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}
