using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    /// <summary>
    /// Below is an example of serialization. Table maps data from MS Server in table tblEmployee to Employee.
    /// When a new instance of Employee is created, Table's methods will be used to help get/set the values below. 
    /// </summary>
    [Table("tblEmployee")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int DepartmentId {get;set;}
    }
}