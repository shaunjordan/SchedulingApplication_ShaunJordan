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
using System.IO;

namespace SchedulingUI
{
    public partial class LoginForm : Form
    {

        CultureInfo ci;
        LoginRecord recordLogin = new LoginRecord();

        public LoginForm(CultureInfo culture)
        {
            InitializeComponent();
            ci = culture;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {


            string userError = Properties.Resources.ResourceManager.GetString("UserNotFound", ci);
            string invalidPass = Properties.Resources.ResourceManager.GetString("InvalidPassword", ci);
            string tryAgain = Properties.Resources.ResourceManager.GetString("PleaseTryAgain", ci);

            #region Login


            UserLogin login = new UserLogin();

            string user = userNameInput.Text;
            string pass = passwordInput.Text;


            int validLogin = login.Login(user, pass);


            if (validLogin == 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
                //MessageBox.Show("Please check the user name or contact your administrator.", "User not found");
                MessageBox.Show(tryAgain, userError);

            }
            else if (validLogin == 1)
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
                MessageBox.Show(tryAgain, invalidPass);
            }
            else
            {
                recordLogin.RecordLogin();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            #endregion

        }
    }
}
