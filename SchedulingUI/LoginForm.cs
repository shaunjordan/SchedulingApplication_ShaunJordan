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


            GetLoggedInUser();
            //if (validLogin)
            //{
            //    DialogResult = System.Windows.Forms.DialogResult.OK;
            //} else
            //{
            //    //return some other catch exception here.
            //    DialogResult = System.Windows.Forms.DialogResult.None;
            //    MessageBox.Show("Login Invalid");
            //}

        }

        public User GetLoggedInUser()
        {

            UserLogin login = new UserLogin();

            string user = userNameInput.Text;
            string pass = passwordInput.Text;



            User validUser = login.ValidLogin(user, pass);


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


            if (validUser.UserId > 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
                MessageBox.Show("Login Invalid");
            }

            return validUser;

        }
    }
}
