using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

/// Here we Select what data we want.  
/// Select "List of Fields" From Employees 
/// Then Place in the data fields defined.
/// 
namespace Simple_Inventory_System.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String Title { get; set; }
        public DateTime HireDate { get; set; } 
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        public String HomePhone { get; set; }
        public String Extension { get; set; }
    }
}