using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassLibrary
{
    class Customer
    {
        //Members

        [DisplayName("Customer ID")]
        public int CustomerId { get; set; }

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [Browsable(false)]
        public int AddressId { get; set; }

        [Browsable(false)]
        public int Active { get; set; }

        [Browsable(false)]
        public DateTime CreateDate { get; set; }

        [Browsable(false)]
        public string CreatedBy { get; set; }

        [Browsable(false)]
        public DateTime LastUpdated { get; set; }

        [Browsable(false)]
        public string LastUpdateBy { get; set; }

        // Methods

        public void AddCustomer() { }
        //Will need to implement database 
    }
}
