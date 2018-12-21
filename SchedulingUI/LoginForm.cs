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
using SchedulingUI;
using System.Device.Location;
using ClassLibrary;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SchedulingUI
{
    public partial class LoginForm : Form
    {

        GeoCoordinateWatcher userLocation = new GeoCoordinateWatcher();
        public LoginForm()
        {
            InitializeComponent();
                        
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            UserLogin login = new UserLogin();

            string user = userNameInput.Text;
            string pass = passwordInput.Text;

            bool validLogin = login.Login(user, pass);


            #region Test
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
            #endregion

            //CultureInfo currentCulture = CultureInfo.CurrentCulture;

            if (validLogin)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            } else
            {
                //return some other catch exception here.
                DialogResult = System.Windows.Forms.DialogResult.None;
                MessageBox.Show("Login Invalid");
            }
            

            //MessageBox.Show(currentCulture.ToString());

            //Main mainForm = new Main();

            //mainForm.Show();

            
        }
    }
}
