using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Simple_Inventory_System
{
    /// Antwoin Davis
    /// Project Simple Inventory System.
    /// Summarry:  Version 1.  Pulls data from SQL server NorthWnd.  Employee data, Customer Data, and Order data is retrieved.  
    /// 

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Database.SetInitializer sets AccountContext fields to null. This allows me to define what fields I want retrieved and how my accountContext table is set up.
            Database.SetInitializer<Simple_Inventory_System.Models.AccountContext>(null);
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}