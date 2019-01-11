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
using System.Resources;
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

        CultureInfo ci;

        public LoginForm(CultureInfo culture)
        {
            InitializeComponent();
            ci = culture;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            //CultureInfo ci = new CultureInfo("de-DE");

            MessageBox.Show(ci.ToString());

            //string userError = Properties.Resources.ResourceManager.GetString("InvalidPassword", ci);

            //UserLogin login = new UserLogin();

            //string user = userNameInput.Text;
            //string pass = passwordInput.Text;


            //int validLogin = login.Login(user, pass);


            //if (validLogin == 0)
            //{
            //    DialogResult = System.Windows.Forms.DialogResult.None;
            //    //MessageBox.Show("Please check the user name or contact your administrator.", "User not found");
            //    MessageBox.Show(userError);

            //}
            //else if (validLogin == 1)
            //{
            //    DialogResult = System.Windows.Forms.DialogResult.None;
            //    MessageBox.Show("Please try again or contact your adminstrator.", "Invalid password");
            //}
            //else
            //{
            //    DialogResult = System.Windows.Forms.DialogResult.OK;
            //}

        }

    }
}
