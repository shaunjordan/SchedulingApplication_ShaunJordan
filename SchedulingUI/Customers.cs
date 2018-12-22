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
            
            MySqlConnection conn = new MySqlConnection(connection.InitConnection());

            conn.Open();

            List <Customer> allCustomers = new List<Customer>();

            string select = "SELECT " +
                            "cust.customerId Customer_Id, " +
                            "cust.customerName Customer_Name, " +
                            "addr.address Address_1, " +
                            "addr.address2 Address_2, " +
                            "city.city City, " +
                            "addr.postalcode Postal_Code," +
                            "ctry.country Country " +
                            "FROM customer cust INNER JOIN address addr ON addr.addressId = cust.addressId " +
                            "INNER JOIN city ON city.cityId = addr.cityId " +
                            "INNER JOIN country ctry ON ctry.countryId = city.countryId " +
                            "ORDER BY cust.customerId ASC";

            using (MySqlCommand command = new MySqlCommand(select, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();
                            customer.CustomerName = reader["userName"].ToString();
                            customer.CustomerId = Convert.ToInt32(reader["customerId"]);
                            allCustomers.Add(customer);
                        }
                    }
                }

            }

            //string select = "SELECT customerName from customer";

            //MySqlDataAdapter adapter = new MySqlDataAdapter(select, connection.InitConnection());
            //DataSet ds = new DataSet();

            //adapter.Fill(ds);

            //MySqlDataReader dataReader =

            customersDataGrid.DataSource = allCustomers;

            //customersDataGrid.DataSource = ds.Tables[0];
            //customersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //for (int i = 0; i < customersDataGrid.RowCount; i++)
            //{
            //    customersDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}

            conn.Close();
        }

        private void editCustBtn_Click(object sender, EventArgs e)
        {
            //customersDataGrid.SelectedRows.
            //MessageBox.Show(customersDataGrid.CurrentRow.Index(0).ToString());
        }
    }
}
