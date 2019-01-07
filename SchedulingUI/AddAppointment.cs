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

namespace SchedulingUI
{
    public partial class AddAppointment : Form
    {

        DBConnection connection = new DBConnection();
        Customer customer = new Customer();
        BindingList<string> customerNames = new BindingList<string>();

        public AddAppointment()
        {
            InitializeComponent();

            startPicker.Format = DateTimePickerFormat.Custom;
            startPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            foreach (Customer customer in customer.GetCustomers())
            {
                customerNames.Add(customer.CustomerName);
            }

            apptCustSelect.DataSource = customerNames;


            
        }

    }
}
