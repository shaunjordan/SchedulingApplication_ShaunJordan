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

            //MySqlConnection conn = new MySqlConnection(connection.InitConnection());

            //connection.InitConnection();

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
                    customer.Country = reader[6].ToString();

                    allCustomers.Add(customer);
                }
            }
            //using (MySqlCommand command = new MySqlCommand(select, connection.GetConnection()))
            //{
            //    using (MySqlDataReader reader = command.ExecuteReader())
            //    {
            //        if (reader != null)
            //        {
            //            while (reader.Read())
            //            {
            //                Customer customer = new Customer();

            //                customer.CustomerId = Convert.ToInt32(reader["customerId"]);
            //                customer.CustomerName = reader["customerName"].ToString();
            //                customer.Address1 = reader["address"].ToString();
            //                customer.Address2 = reader["address2"].ToString();
            //                customer.City = reader["city"].ToString();
            //                customer.PostalCode = reader["postalcode"].ToString();
            //                customer.Country = reader["country"].ToString();

            //                allCustomers.Add(customer);
            //            }
            //        }
            //    }

            //}

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

            connection.CloseConnection();
        }

        private void editCustBtn_Click(object sender, EventArgs e)
        {
            //customersDataGrid.SelectedRows.
            MessageBox.Show(customersDataGrid.CurrentRow.DataBoundItem.ToString());
        }
    }
}
