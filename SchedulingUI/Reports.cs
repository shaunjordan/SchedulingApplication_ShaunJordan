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
    public partial class Reports : Form
    {

        DBConnection conn = new DBConnection();
        ReportManager reportManager = new ReportManager();

        public Reports()
        {
            InitializeComponent();
        }

        private void exitReportsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typesByMonthBtn_Click(object sender, EventArgs e)
        {
            conn.InitConnection();
            
            reportManager.TypesByMonth(conn.GetConnection());
           
            conn.CloseConnection();
        }

        private void schedBtn_Click(object sender, EventArgs e)
        {
            conn.InitConnection();

            reportManager.ConsultantSchedules(conn.GetConnection());

            conn.CloseConnection();
        }

        private void totalCustsBtn_Click(object sender, EventArgs e)
        {
            conn.InitConnection();

            reportManager.CustomersByCountry(conn.GetConnection());

            conn.CloseConnection();
        }
    }
}
