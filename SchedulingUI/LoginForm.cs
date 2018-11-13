using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Globalization;
using SchedulingUI.Properties;

namespace SchedulingUI
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
            MessageBox.Show(Properties.strings.Hello);
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
