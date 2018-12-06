using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using SchedulingUI.Properties;
using System.Device.Location;
using ClassLibrary;

namespace SchedulingUI
{
    public partial class LoginForm : Form
    {

        GeoCoordinateWatcher userLocation = new GeoCoordinateWatcher();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();

            //conn.
            /*
             * 
             * Getting the culture info
             * 
            CultureInfo ci = new CultureInfo("de-DE");
            Properties.Resources.Culture = ci;
            string s1 = SchedulingUI.Properties.Resources.Hello;
            MessageBox.Show(s1);
            */

            //MessageBox.Show(userLocation.Position.Location.ToString());

            //MySqlConnection connection = new MySqlConnection();

            //connection.Open();

            ///*
            // * sql string
            // * if username and password == valid
            // * close this form
            // * show mainform
            // * else
            // * display an error to the user in English and German
            // * Messagebox.Show(); 
            // */

           

            //connection.Close();

        }
    }
}
