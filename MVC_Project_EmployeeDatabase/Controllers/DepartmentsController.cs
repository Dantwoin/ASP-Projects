using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;

///<summary>
///     DepartmentsController controls how data is used/got.  
///     
///     EmployeeContext references the server.
///     Employee acts like a table. We will grab data from the Server and map it to the Employee data set.
///     
///     ActionResult Index is used in Views index department page. It is passed data selected by the user and 
///     a list of tables is returned.
///     
///</summary>
namespace MVC_Project.Controllers
{
    public class DepartmentsController : Controller
    {

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Department> departments = employeeContext.Departments.ToList();
            return View(departments);
        }

    }
}
