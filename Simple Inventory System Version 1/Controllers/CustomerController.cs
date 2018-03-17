using Simple_Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Inventory_System.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            AccountContext accountContext = new AccountContext();
            List<Customer> customers = accountContext.Customers.ToList();
            return View(customers);
        }

        public ActionResult Details(String id)
        {
            AccountContext accountContext = new AccountContext();
            Customer customer = accountContext.Customers.Single(cust => cust.CustomerID == id);
            customer.Orders = accountContext.Orders.Where(order => order.CustomerID == id).ToList();
            return View(customer);
        }

    }
}
