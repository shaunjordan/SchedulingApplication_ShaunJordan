using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.IO;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class ReportManager
    {
        public void TypesByMonth(MySqlConnection conn)
        {
            string writePath = AppDomain.CurrentDomain.BaseDirectory + @"\TypesByMonth.txt";
            string types_By_Month = "types_By_Month";
            
            MySqlCommand cmd = new MySqlCommand(types_By_Month, conn);
            cmd.CommandType = CommandType.StoredProcedure;
                        
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                using (StreamWriter file = new StreamWriter(writePath, false))
                {
                    file.WriteLine(reader.GetName(0) + ',' + reader.GetName(1) + ',' + reader.GetName(2));

                    while (reader.Read())
                    {
                        file.WriteLine(reader[0].ToString() + ',' + reader[1].ToString() + ',' + reader[2].ToString());
                    }
                }
            }

            MessageBox.Show("Report output successfully!");

        }

        public void ConsultantSchedules(MySqlConnection conn)
        {
            string writePath = AppDomain.CurrentDomain.BaseDirectory + @"\ConsultantSchedules.txt";
            string consultant_schedules = "consultant_schedules";

            MySqlCommand cmd = new MySqlCommand(consultant_schedules, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                using (StreamWriter file = new StreamWriter(writePath, false))
                {
                    file.WriteLine(reader.GetName(0) + ',' + reader.GetName(1) + ',' + reader.GetName(2) + ',' + reader.GetName(3) + ',' + reader.GetName(4));

                    while (reader.Read())
                    {
                        file.WriteLine(reader[0].ToString() + ',' + reader[1].ToString() + ',' + reader[2].ToString() + ',' + reader[3].ToString() + ',' + reader[4].ToString());
                    }
                }
            }

            MessageBox.Show("Report output successfully!");
        }

        public void CustomersByCountry(MySqlConnection conn)
        {
            string writePath = AppDomain.CurrentDomain.BaseDirectory + @"\CustomersByCountry.txt";
            string customers_By_Country = "customers_By_Country";

            MySqlCommand cmd = new MySqlCommand(customers_By_Country, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                using (StreamWriter file = new StreamWriter(writePath, false))
                {
                    file.WriteLine(reader.GetName(0) + ',' + reader.GetName(1));

                    while (reader.Read())
                    {
                        file.WriteLine(reader[0].ToString() + ',' + reader[1].ToString());
                    }
                }
            }

            MessageBox.Show("Report output successfully!");
        }
    }
}
