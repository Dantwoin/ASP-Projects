using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;

/// <comment>
/// Summary:
///     EmployeeController controls how data is used/got.  
///     
///     EmployeeContext references the server.
///     Employee acts like a table. We will grab data from the Server and map it to the Employee data set.
///     
///     ActionResult Index and Details are used in Views index and detail pages. They are passed in data selected by the user and 
///     a list of tables is returned.
///     
/// </comment>

namespace MVC_Project.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeID == id);
            return View(employee);
        }


    }
}
