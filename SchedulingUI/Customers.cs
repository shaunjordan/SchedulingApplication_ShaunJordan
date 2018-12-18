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
            //connection.InitConnection();

            string select = "SELECT customerId, customerName FROM customer";
           
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connection.InitConnection());
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            customersDataGrid.DataSource = ds.Tables[0];
            //customersDataGrid.AutoGenerateColumns = true;
            customersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            customersDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            connection.CloseConnection();                       
        }
    }
}
