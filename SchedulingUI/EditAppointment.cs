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
using MySql.Data.MySqlClient;

namespace SchedulingUI
{
    public partial class EditAppointment : Form
    {
        
        DBConnection conn = new DBConnection();

        DBManager dbManager = new DBManager();

        private List<string> appointmentTypes = new List<string>
        {
            "Introductory",
            "Follow-up",
            "Consultation",
            "Other"
        };

        private int apptId;

        public EditAppointment(int appointmentId)
        {
            InitializeComponent();

            conn.InitConnection();

            editStartTimePicker.Format = DateTimePickerFormat.Custom;
            editStartTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            editStartTimePicker.Value = DateTime.Now; //enter the correct datetime from the appointment

            editEndTimePicker.Format = DateTimePickerFormat.Custom;
            editEndTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            editEndTimePicker.Value = DateTime.Now; //enter the correct datetime from the appointment

            editApptTypeText.DataSource = appointmentTypes;

            apptId = appointmentId;

            string select = "SELECT " +
                            "title," +
                            "customerName," +
                            "description," +
                            "contact," +
                            "location," +
                            "type," +
                            "url, " +
                            "start, " +
                            "end " +
                            "FROM appointment " +
                            "INNER JOIN customer " +
                            "ON appointment.customerId = customer.customerId " +
                            "WHERE appointmentId = @appointmentId";

            MySqlCommand cmd = new MySqlCommand(select, conn.GetConnection());
            cmd.Parameters.AddWithValue("@appointmentId", apptId);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {

                    editApptTitleText.Text = reader[0].ToString();
                    editApptCustText.Text = reader[1].ToString();
                    editApptDescText.Text = reader[2].ToString();
                    editApptLocationText.Text = reader[3].ToString();
                    editApptContactText.Text = reader[4].ToString();
                    editApptTypeText.Text = reader[5].ToString();
                    editUrlText.Text = reader[6].ToString();

                    DateTime pickerStart = DateTime.Parse(reader[7].ToString());
                    DateTime pickerEnd = DateTime.Parse(reader[8].ToString());

                    editStartTimePicker.Text = pickerStart.ToLocalTime().ToString();
                    editEndTimePicker.Text = pickerEnd.ToLocalTime().ToString();
                    
                }
            }

            reader.Close();
            reader.Dispose();

            conn.CloseConnection();
            
        }

        private void cancelAddApptBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Changes will not be saved.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void saveApptEditBtn_Click(object sender, EventArgs e)
        {
            conn.InitConnection();

            
            string title = editApptTitleText.Text;
            string description = editApptDescText.Text;
            string contact = editApptContactText.Text;
            string location = editApptLocationText.Text;
            string type = editApptTypeText.Text;
            string url = editUrlText.Text;
            DateTime startTime = DateTime.Parse(editStartTimePicker.Text);
            DateTime endTime = DateTime.Parse(editEndTimePicker.Text);

            DateTime startUTC = startTime.ToUniversalTime();
            DateTime endUTC = endTime.ToUniversalTime();

            dbManager.EditAppointment(apptId, title, description, contact, location, type, url, startUTC.ToString("yyyy-MM-dd HH:mm:ss"), endUTC.ToString("yyyy-MM-dd HH:mm:ss"), User.displayName, conn.GetConnection());

            this.Close();

            conn.CloseConnection();
        }
    }
}
