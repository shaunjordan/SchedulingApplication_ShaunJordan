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
            //TODO - I need to pass the user id out of here
            //maybe create a user object and add it to a list
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void custMgrBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }
    }
}
