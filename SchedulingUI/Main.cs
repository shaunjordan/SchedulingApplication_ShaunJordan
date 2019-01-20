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
    public partial class Main : Form
    {
        DBManager dbm = new DBManager();
        DBConnection conn = new DBConnection();

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(User.displayName);
            DateTime myDate = DateTime.UtcNow;
            DateTime toLoc = myDate.ToLocalTime();

           


            MessageBox.Show(toLoc.ToString());
        }

        private void custMgrBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, " + User.displayName;

            //TODO: this is here to populate the appts customer selection
            //if user wants to add appointments before customers
            //it could be moved to activate when the appointments screen is activated
            conn.InitConnection();
            dbm.PopulateCustomerTable(conn.GetConnection());
            conn.CloseConnection();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //TODD: confirm exit
            Application.Exit();
        }

        private void apptMgrBtn_Click(object sender, EventArgs e)
        {
            Appointments appointmentForm = new Appointments();

            appointmentForm.Show();
        }
    }
}
