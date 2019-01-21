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
    public partial class Appointments : Form
    {

        private List<string> months = new List<string> {
            "January", "February", "March",
            "April","May","June",
            "July","August","September",
            "October","November","December"};

        

        DBConnection conn = new DBConnection();
        DBManager apptManager = new DBManager();
        Appointment appointments = new Appointment();

        public Appointments()
        {
            InitializeComponent();
            monthPicker.DataSource = months;
            weekPicker.DataSource = PopulateWeeks();
        }

        

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();

            addAppointment.Show();
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.InitConnection();

            //Clear binding list before adding new data from the DB
            appointments.ClearMonthly();

            int month = months.IndexOf(monthPicker.Text) + 1; //plus one to get the month number

            //MessageBox.Show(month.ToString());

            apptManager.UpdateMonthGrid(month, conn.GetConnection());

            BindingSource monthlyAppointments = new BindingSource();
            monthlyAppointments.DataSource = appointments.GetMonthlyAppointments();

            appointmentsDataGrid.DataSource = monthlyAppointments;



            conn.CloseConnection();
        }

        public List<string> PopulateWeeks()
        {
            List<string> weeks = new List<string>();
            int year = Convert.ToInt32(DateTime.Now.Year);
            DateTime start = new DateTime(year, 1, 1);

            start = start.AddDays(1 - (int)start.DayOfWeek);
            DateTime end = start.AddDays(6);

            while (start.Year < 1 + year)
            {
                weeks.Add(string.Format("Week: {0:yyyy-MM-dd} to {1:yyyy-MM-dd}", start, end));
                start = start.AddDays(7);
                end = end.AddDays(7);
            }

            return weeks;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
