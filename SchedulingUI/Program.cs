using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Globalization;


namespace SchedulingUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //sourced from: https://stackoverflow.com/questions/8879259/get-current-location-as-specified-in-region-and-language-in-c-sharp
            var regKeyGeoId = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Control Panel\International\Geo");
            var geoID = (string)regKeyGeoId.GetValue("Nation");
            var allRegions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.ToString()));
            var regionInfo = allRegions.FirstOrDefault(r => r.GeoId == Int32.Parse(geoID));

            CultureInfo ci = new CultureInfo(regionInfo.ToString());

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            
            Main mainScreen = new Main();
            LoginForm loginForm = new LoginForm(ci);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(mainScreen);
            }


        }

    }
}
