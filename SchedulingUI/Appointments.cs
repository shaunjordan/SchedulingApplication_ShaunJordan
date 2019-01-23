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

        private List<string> startWeeks = new List<string>();
        private List<string> endWeeks = new List<string>();

        DBConnection conn = new DBConnection();

        DBManager apptManager = new DBManager();
        

        Appointment appointments = new Appointment();
        Appointment testApts = new Appointment();


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

        private List<string> PopulateWeeks()
        {
            List<string> weeks = new List<string>();
            int year = Convert.ToInt32(DateTime.Now.Year);
            DateTime start = new DateTime(year, 1, 1);

            start = start.AddDays(1 - (int)start.DayOfWeek);
            DateTime end = start.AddDays(6);

            while (start.Year < 1 + year)
            {
                weeks.Add(string.Format("{0:yyyy-MM-dd} to {1:yyyy-MM-dd}", start, end));
                start = start.AddDays(7);
                end = end.AddDays(7);
            }

            return weeks;
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void weekPicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.InitConnection();
            //run a query to populate the table

            appointments.ClearWeekly();

            //DateTime startingDate = DateTime.Parse(weekPicker.Text.Substring(0, 10));
            //DateTime endingDate = DateTime.Parse(weekPicker.Text.Substring(14, 10));


            //apptManager.UpdateWeekGrid(startingDate.ToString("yyyy-MM-dd HH:mm:ss"), endingDate.ToString("yyyy-MM-dd HH:mm:ss"), conn.GetConnection());

            string startDate = weekPicker.Text.Substring(0, 10);
            string endDate = weekPicker.Text.Substring(14, 10);

            apptManager.UpdateWeekGrid(startDate, endDate, conn.GetConnection());
            //BindingList<Appointment> test = new BindingList<Appointment>();

            //MessageBox.Show(startDate);


            BindingSource weeklyAppointments = new BindingSource();
            weeklyAppointments.DataSource = appointments.GetWeeklyAppointments();

            weeklyDataGrid.DataSource = weeklyAppointments;

            //MessageBox.Show(testApts.GetWeeklyAppointments().Count.ToString());

            conn.CloseConnection();
            //DateTime startingDate = DateTime.Parse(weekPicker.Text.Substring(0, 10));
            //DateTime endingDate = DateTime.Parse(weekPicker.Text.Substring(14, 10));

            //MessageBox.Show(startingDate.ToString("yyyy-MM-dd HH:mm:ss"));
            //MessageBox.Show(endingDate.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
