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

        private BindingList<Customer> AllCustomers = new BindingList<Customer>();

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

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("Country")]
        public string Country { get; set; }

        
        public void AddCustomer(Customer customer) {

            AllCustomers.Add(customer);

        }

        public void ClearList()
        {
            AllCustomers.Clear();
        }

        public BindingList<Customer> GetCustomers()
        {
            return AllCustomers;
        }

    }
}
