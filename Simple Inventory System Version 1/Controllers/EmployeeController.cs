using Simple_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Inventory_System.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            AccountContext accountContext = new AccountContext();
            List<Employee> employees = accountContext.Employees.ToList();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            AccountContext accountContext = new AccountContext();
            Employee employee = accountContext.Employees.Single(emp => emp.EmployeeID == id);
            return View(employee);
        }

    }
}
