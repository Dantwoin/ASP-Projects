using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// Here we Select what data we want.  
/// Select "List of Fields" From Customers
/// Then Place in the data fields defined.

namespace Simple_Inventory_System.Models
{
    [Table("Customers")]
    public class Customer
    {
        public String CustomerID { get; set; }
        public String CompanyName { get; set; }
        public String ContactName { get; set; }
        public String ContactTitle { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; } 
        public String PostalCode { get; set; }
        public String Country {get;set;}
        public String Phone { get; set; }

        // This will store a list of table order information.
        public virtual ICollection<Order> Orders { get; set; }
    }
}