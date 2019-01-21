using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class LoginRecord
    {

        public void RecordLogin()
        {
            
            DateTime logTime = DateTime.Now;

            string log = "User: " + User.displayName + " Time: " + logTime + Environment.NewLine;

            string path = AppDomain.CurrentDomain.BaseDirectory + @"\UserLogins.txt";

           
            File.AppendAllText(path, log);
            
        }
    }
}
