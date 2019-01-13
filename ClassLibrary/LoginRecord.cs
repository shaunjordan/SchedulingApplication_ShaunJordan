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
            

            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //    TextWriter textWriter = new StreamWriter(path);
            //    textWriter.WriteLine(log);
            //    textWriter.Close();
            //}
            //else if (File.Exists(path))
            //{
            //    using
            //}

            //System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\UserLogins", log);
        }
    }
}
