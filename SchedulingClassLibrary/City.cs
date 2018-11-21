﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulingClassLibrary
{
    public class City
    {
        public int CityId { get; set; }

        public string CityName { get; set; }

        public int CountryId { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; }  
    }
}
