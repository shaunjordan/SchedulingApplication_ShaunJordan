using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassLibrary
{
    public class Customer
    {
        //Members

        public List<Customer> allCustomers;

        [DisplayName("Customer ID")]
        public int CustomerId { get; set; }

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [DisplayName("Address 1")]
        public string Address1 { get; set; }

        [DisplayName("Address 2")]
        public string Address2 { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [DisplayName("Country")]
        public string Country { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }

        //[Browsable(false)]
        //public int AddressId { get; set; }

        //[Browsable(false)]
        //public int Active { get; set; }

        //[Browsable(false)]
        //public DateTime CreateDate { get; set; }

        //[Browsable(false)]
        //public string CreatedBy { get; set; }

        //[Browsable(false)]
        //public DateTime LastUpdated { get; set; }

        //[Browsable(false)]
        //public string LastUpdateBy { get; set; }

        // Methods

        public void AddCustomer(Customer customer) {

            allCustomers.Add(customer);

        }
        //Will need to implement database 
    }
}
