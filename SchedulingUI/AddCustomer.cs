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

        DBManager newCustomer = new DBManager();

        Validations validations = new Validations();

        
        
        //private List<string> requiredFields = new List<string>();


        public AddCustomer()
        {
            InitializeComponent();

            countrySelectBox.SelectedIndex = 0;
            
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {


            connection.InitConnection();

            List<TextBox> requiredInputs = new List<TextBox> { custNameTextBox, addressLine1, cityTextBox, postalCodeTextbox, phoneTextBox };
            
            var checkFields = requiredInputs.Where(input => String.IsNullOrWhiteSpace(input.Text))
                //TODO: explain this lambda
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
                                  
            connection.CloseConnection();

            

        }

        private void ErrorAlert(string errors)
        {
            MessageBox.Show(errors);
        }

        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            //TODO: are you sure you want to cancel?
            this.Close();

        }
    }
}
