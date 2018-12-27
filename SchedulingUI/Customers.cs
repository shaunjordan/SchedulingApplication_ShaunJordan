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
using MySql.Data;
using MySql.Data.MySqlClient;


namespace SchedulingUI
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();

            DBConnection connection = new DBConnection();
            connection.InitConnection();
            //MySqlConnection conn = connection.GetConnection();
            //conn.Open();

            List<Customer> allCustomers = new List<Customer>();

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

            MySqlCommand cmd = new MySqlCommand(select, connection.GetConnection());

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
                    

                    allCustomers.Add(customer);
                    
                }
            }
            
            customersDataGrid.DataSource = allCustomers;

            reader.Close();
            reader.Dispose();
            connection.CloseConnection();
            
            
        }

        private void editCustBtn_Click(object sender, EventArgs e)
        {
            //customersDataGrid.SelectedRows.
            MessageBox.Show(customersDataGrid.CurrentRow.DataBoundItem.ToString());
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerScreen = new AddCustomer();

            addCustomerScreen.Show();
        }
    }
}
