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

        DBManager m = new DBManager();
        DBConnection connection = new DBConnection();
        Customer customer = new Customer();

        public Customers()
        {
            InitializeComponent();

            #region old


            //DBConnection connection = new DBConnection();
            //connection.InitConnection();

            //BindingList<Customer> AllCustomers = new BindingList<Customer>();

            //string select = "SELECT " +
            //                "cust.customerId," +
            //                "cust.customerName," +
            //                "addr.address," +
            //                "addr.address2," +
            //                "city.city," +
            //                "addr.postalcode," +
            //                "addr.phone," +
            //                "ctry.country " +
            //                "FROM customer cust INNER JOIN address addr ON addr.addressId = cust.addressId " +
            //                "INNER JOIN city ON city.cityId = addr.cityId " +
            //                "INNER JOIN country ctry ON ctry.countryId = city.countryId " +
            //                "ORDER BY cust.customerId ASC";

            //MySqlCommand cmd = new MySqlCommand(select, connection.GetConnection());

            //MySqlDataReader reader = cmd.ExecuteReader();

            //if (reader != null)
            //{
            //    while (reader.Read())
            //    {
            //        Customer customer = new Customer();
            //        customer.CustomerId = Convert.ToInt32(reader[0]);
            //        customer.CustomerName = reader[1].ToString();
            //        customer.Address1 = reader[2].ToString();
            //        customer.Address2 = reader[3].ToString();
            //        customer.City = reader[4].ToString();
            //        customer.PostalCode = reader[5].ToString();
            //        customer.Phone = reader[6].ToString();
            //        customer.Country = reader[7].ToString();

            //        AllCustomers.Add(customer);

            //        //customer.AddCustomer(customer);

            //    }
            //}

            //customersDataGrid.DataSource = AllCustomers;

            //reader.Close();
            //reader.Dispose();
            //connection.CloseConnection();
            #endregion


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

        private void Customers_Activated(object sender, EventArgs e)
        {
            
            connection.InitConnection();
              
            customer.ClearList();

            m.PopulateCustomerTable(connection.GetConnection());

            BindingSource customerListSource = new BindingSource();
            customerListSource.DataSource = customer.GetCustomers();

            customersDataGrid.DataSource = customerListSource;
            connection.CloseConnection();

        }

        private void delCustBtn_Click(object sender, EventArgs e)
        {
            
            int rowIndex = customersDataGrid.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = customersDataGrid.Rows[rowIndex];

            int customerId = Convert.ToInt32(selectedRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure you want to delete the selected customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.InitConnection();
                
                m.DeleteCustomer(connection.GetConnection(), customerId);
                customer.ClearList();
                m.PopulateCustomerTable(connection.GetConnection());
                
            }


            connection.CloseConnection();

            //MessageBox.Show(customerId.ToString());

        }
    }
}
