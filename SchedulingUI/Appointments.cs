using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingUI
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();

            addAppointment.Show();
        }
    }
}
