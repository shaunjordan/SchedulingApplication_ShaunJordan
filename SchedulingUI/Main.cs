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

       

        public Main()
        {
                        
            InitializeComponent();
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.displayName);
        }

        private void custMgrBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, " + User.displayName;
        }
    }
}
