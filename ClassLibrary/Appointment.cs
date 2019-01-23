using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassLibrary
{
    public class Appointment
    {

        private static BindingList<Appointment> MonthlyAppointments = new BindingList<Appointment>();

        private static BindingList<Appointment> WeeklyAppointments = new BindingList<Appointment>();

        [DisplayName("Appointment Id")]
        public int AppointmentId { get; set; }

        [Browsable(false)]
        public int CustomerId { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("Contact")]
        public string Contact { get; set; }

        [DisplayName("Type")]
        public string Type { get; set; }

        [DisplayName("Url")]
        public string Url { get; set; }

        [DisplayName("Start Time")]
        public DateTime Start { get; set; }

        [DisplayName("End Time")]
        public DateTime End { get; set; }

        public BindingList<Appointment> GetMonthlyAppointments()
        {
            return MonthlyAppointments;
        }

        public void AddMonthlyAppointment(Appointment mAppt)
        {
            MonthlyAppointments.Add(mAppt);
        }

        public void ClearMonthly()
        {
            MonthlyAppointments.Clear();
        }

        public BindingList<Appointment> GetWeeklyAppointments()
        {
            return WeeklyAppointments;
        }
           
        public void AddWeeklyAppointment(Appointment wAppt)
        {
            WeeklyAppointments.Add(wAppt);
        }

        public void ClearWeekly()
        {
            WeeklyAppointments.Clear();
        }
    }
}
