using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulingClassLibrary
{
    public class Country
    {
        //Members

        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        public string LastUpdateBy { get; set; }

    }
}
