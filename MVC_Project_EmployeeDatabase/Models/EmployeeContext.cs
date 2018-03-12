using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/// <comment>
/// EmployeeContext: EmployeeContext creates a link between a MS server and the program. EmployeeContext class will be used to access the server and then employee class will be used to select the table information to get/set. 
/// </comment>
/// <remark>
/// Check Web.Config.  There the EmployeeContext is defined and a connection between the Ms Server and the EmployeeContext Data is linked. 
/// </remark>

namespace MVC_Project.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}