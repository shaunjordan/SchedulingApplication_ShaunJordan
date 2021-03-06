﻿using System;
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
    public partial class AddAppointment : Form
    {

        DBConnection connection = new DBConnection();
        DBManager dBManager = new DBManager();
        Customer customer = new Customer();
        Appointment appointment = new Appointment();

        BindingList<string> customerNames = new BindingList<string>();

        private List<string> appointmentTypes = new List<string>
        {
            "Introductory",
            "Follow-up",
            "Consultation",
            "Other"
        };

        

        public AddAppointment()
        {
            InitializeComponent();

            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            startTimePicker.Value = DateTime.Now;

            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            endTimePicker.Value = DateTime.Now;

            foreach (Customer customer in customer.GetCustomers())
            {
                customerNames.Add(customer.CustomerName);
            }

            customerNames.Select(name => customer.GetCustomers());
            
            

            apptCustSelect.DataSource = customerNames;

            apptTypeText.DataSource = appointmentTypes;

            
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            connection.InitConnection();

            

            TimeZone localTime = TimeZone.CurrentTimeZone;

            string customer = apptCustSelect.Text;
            string title = apptTitleText.Text;
            string descr = apptDescText.Text;
            string location = apptLocationText.Text;
            string contact = apptContactText.Text;
            string type = apptTypeText.Text;
            string url = urlText.Text;
            DateTime startTime = DateTime.Parse(startTimePicker.Text);
            DateTime endTime = DateTime.Parse(endTimePicker.Text);


            /* lambda expression used with LINQ to avoid manually looping through each item in the list of available weekdays
             * to determine if chosen start day or end day is outside of business hours.
             * the use of a lamba here simplifies the code and makes the footprint smaller
             * A lamba can be used here to accomplish the same goals as a complicated for-loop.
             */

            //if startTime is before set business start, after set business end, or not a weekday, or before current day fail out
            if (endTime < startTime)
            {
                MessageBox.Show("Appointment cannot end before starting. Adjust appointment times.");
            }
            else if (appointment.GetMonthlyAppointments()
                .Where(x => (startTime >= x.Start && startTime <= x.End)
                || (endTime >= x.Start && endTime <= x.End)
                || (x.Start >= startTime && x.Start <= endTime)
                ).Count() > 0)
            {
                MessageBox.Show("Appointments cannot overalp. Please adjust appointment times.");
            }
            else if ((int)(startTime.TimeOfDay.TotalHours * 100) < Appointment.businessStart ||
                (int)(endTime.TimeOfDay.TotalHours * 100) > Appointment.businessEnd ||
                !Appointment.businessDays.Any(day => day == startTime.DayOfWeek.ToString()) ||
                !Appointment.businessDays.Any(day => day == endTime.DayOfWeek.ToString()) ||
                startTime < DateTime.Now || endTime < DateTime.Now)
            {
                MessageBox.Show("Appointment outside of business hours. Please adjust appointment time.");
            }
            else
            {
                //local time set to UTC before entry into database
                DateTime startUTC = startTime.ToUniversalTime();
                DateTime endUTC = endTime.ToUniversalTime();


                bool appointmentAdded = dBManager.AddAppointment(customer, title, descr, location, contact, type, url, startUTC.ToString("yyyy-MM-dd HH:mm:ss"), endUTC.ToString("yyyy-MM-dd HH:mm:ss"), connection.GetConnection());

                this.Close();
            }


            connection.CloseConnection();
        }

        private void cancelAddApptBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Changes will not be saved.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
