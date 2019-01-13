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
        DBManager dBManager = new DBManager();
        Customer customer = new Customer();
        BindingList<string> customerNames = new BindingList<string>();
        

        public AddAppointment()
        {
            InitializeComponent();

            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            foreach (Customer customer in customer.GetCustomers())
            {
                customerNames.Add(customer.CustomerName);
            }



            apptCustSelect.DataSource = customerNames;
            

            
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            connection.InitConnection();

            string customer = apptCustSelect.Text;
            string title = apptTitleText.Text;
            string descr = apptDescText.Text;
            string location = apptLocationText.Text;
            string contact = apptContactText.Text;
            string type = apptTypeText.Text;
            string url = urlText.Text;
            string startTime = startTimePicker.Text;
            string endTime = endTimePicker.Text;


            DateTime startTimeValue = DateTime.Parse(startTime);
            DateTime endTimeValue = DateTime.Parse(endTime);


            dBManager.AddAppointment(customer, title, descr, location, contact, type, url, startTimeValue.ToString("yyyy-MM-dd HH:mm:ss"), endTimeValue.ToString("yyyy-MM-dd HH:mm:ss"), connection.GetConnection());


            //MessageBox.Show(startDateValue.ToString("yyy-MM-dd HH:mm:ss"));

            connection.CloseConnection();
        }
    }
}
