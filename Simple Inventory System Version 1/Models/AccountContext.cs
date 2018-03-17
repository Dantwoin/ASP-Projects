using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Simple_Inventory_System.Models
{
    // AccountContext will be called to retrieve data from SQL server.  Essentially, if this was an SQL query this statement would be for example "From Customers".
    // It defines what Table we are getting data from.

    public class AccountContext : DbContext
    {
        public DbSet<Customer> Customers{get; set;}
        public DbSet<Employee> Employees{get; set;}
        public DbSet<Order> Orders { get; set; }
                
    }
}