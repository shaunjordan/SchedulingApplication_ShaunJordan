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

        
        DBManager dbm = new DBManager();
        DBConnection connection = new DBConnection();
        Customer customer = new Customer();

        public Customers()
        {
            InitializeComponent();

        }


        private void addCustBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerScreen = new AddCustomer();

            addCustomerScreen.Show();
        }


        private void editCustBtn_Click(object sender, EventArgs e)
        {
            
            int rowIndex = customersDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = customersDataGrid.Rows[rowIndex];

            int custId = Convert.ToInt32(selectedRow.Cells[0].Value);

            EditCustomer editCustomer = new EditCustomer(custId);
            // pass the customer id to the update customer
            editCustomer.Show();

        }

        private void delCustBtn_Click(object sender, EventArgs e)
        {

            int rowIndex = customersDataGrid.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = customersDataGrid.Rows[rowIndex];

            int customerId = Convert.ToInt32(selectedRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure you want to delete the selected customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.InitConnection();

                dbm.DeleteCustomer(connection.GetConnection(), customerId);
                customer.ClearList();
                dbm.PopulateCustomerTable(connection.GetConnection());

            }


            connection.CloseConnection();

            //MessageBox.Show(customerId.ToString());

        }

        private void Customers_Activated(object sender, EventArgs e)
        {
            
            connection.InitConnection();
              
            customer.ClearList();

            dbm.PopulateCustomerTable(connection.GetConnection());

            BindingSource customerListSource = new BindingSource();
            customerListSource.DataSource = customer.GetCustomers();

            customersDataGrid.DataSource = customerListSource;
            connection.CloseConnection();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
