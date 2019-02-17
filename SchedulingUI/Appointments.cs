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

        private static List<string> months = new List<string> {
            "January", "February", "March",
            "April","May","June",
            "July","August","September",
            "October","November","December"};

        private List<string> startWeeks = new List<string>();
        private List<string> endWeeks = new List<string>();

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
            //datagrid source is static binding list
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

            appointments.ClearWeekly();

            DateTime startingDate = DateTime.Parse(weekPicker.Text.Substring(0, 10));

            //set end date to max datetime value
            //capture appointments earlier than or on 11:59:59
            DateTime endingDate = DateTime.Parse(weekPicker.Text.Substring(14, 10)).AddDays(1).Date.AddSeconds(-1);
                       
            apptManager.UpdateWeekGrid(startingDate.ToString("yyyy-MM-dd HH:mm:ss"), endingDate.ToString("yyyy-MM-dd HH:mm:ss"), conn.GetConnection());

            BindingSource weeklyAppointments = new BindingSource();
            weeklyAppointments.DataSource = appointments.GetWeeklyAppointments();

            weeklyDataGrid.DataSource = weeklyAppointments;
                        
            conn.CloseConnection();
            
        }

        private void editApptBtn_Click(object sender, EventArgs e)
        {

            int rowIndex;
            int apptId;
            DataGridViewRow selectedRow;

            if (apptsTabs.SelectedTab == apptsTabs.TabPages["apptsByMonthTab"])
            {
                rowIndex = appointmentsDataGrid.SelectedCells[0].RowIndex;

                selectedRow = appointmentsDataGrid.Rows[rowIndex];

                apptId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            else
            {
                rowIndex = weeklyDataGrid.SelectedCells[0].RowIndex;

                selectedRow = weeklyDataGrid.Rows[rowIndex];

                apptId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }

            EditAppointment editAppointment = new EditAppointment(apptId);
            editAppointment.Show();

            //MessageBox.Show(apptId.ToString());
        }

        private void delApptBtn_Click(object sender, EventArgs e)
        {
            int rowIndex;
            int apptId;
            DataGridViewRow selectedRow;
            
            if (apptsTabs.SelectedTab == apptsTabs.TabPages["apptsByMonthTab"])
            {
                rowIndex = appointmentsDataGrid.SelectedCells[0].RowIndex;

                selectedRow = appointmentsDataGrid.Rows[rowIndex];

                apptId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            else
            {
                rowIndex = weeklyDataGrid.SelectedCells[0].RowIndex;

                selectedRow = weeklyDataGrid.Rows[rowIndex];

                apptId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }


            if (MessageBox.Show("Are you sure you want to delete the selected appointment?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.InitConnection();

                int month = months.IndexOf(monthPicker.Text) + 1;

                DateTime startingDate = DateTime.Parse(weekPicker.Text.Substring(0, 10));
                DateTime endingDate = DateTime.Parse(weekPicker.Text.Substring(14, 10)).AddDays(1).Date.AddSeconds(-1);

                apptManager.DeleteAppointment(conn.GetConnection(), apptId);

                appointments.ClearMonthly();
                appointments.ClearWeekly();
                                
                apptManager.UpdateMonthGrid(month, conn.GetConnection());
                apptManager.UpdateWeekGrid(startingDate.ToString("yyyy-MM-dd HH:mm:ss"), endingDate.ToString("yyyy-MM-dd HH:mm:ss"), conn.GetConnection());
            }

            conn.CloseConnection();

        }

        private void Appointments_Activated(object sender, EventArgs e)
        {
            conn.InitConnection();

            int month = months.IndexOf(monthPicker.Text) + 1;

            DateTime startingDate = DateTime.Parse(weekPicker.Text.Substring(0, 10));
            DateTime endingDate = DateTime.Parse(weekPicker.Text.Substring(14, 10)).AddDays(1).Date.AddSeconds(-1);

            appointments.ClearMonthly();
            appointments.ClearWeekly();

            apptManager.UpdateMonthGrid(month, conn.GetConnection());
            apptManager.UpdateWeekGrid(startingDate.ToString("yyyy-MM-dd HH:mm:ss"), endingDate.ToString("yyyy-MM-dd HH:mm:ss"), conn.GetConnection());

            conn.CloseConnection();
        }
    }
}
