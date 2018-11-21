using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulingClassLibrary
{
    class Customer
    {
        //Members

        public int CustomerId { get; set;}

        public string CustomerName { get; set; }

        public int AddressId { get; set; }

        public int Active { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdated { get; set; }

        public string LastUpdateBy { get; set; }

        // Methods

        public void AddCustomer() { }
        //Will need to implement database 
    }
}
