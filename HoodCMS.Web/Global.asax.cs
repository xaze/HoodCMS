using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HoodCMS.Web.Models;
using HoodCMS.Data.Interfaces;
using HoodCMS.Data.Concrete;
using Ninject.Web.Mvc;
using Ninject;
using HoodCMSI.Web.Modules;
using System.Reflection;

namespace HoodCMS.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : NinjectHttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Paged",
                "{controller}/Page{page}",
                new { controller = "Article", action = "Index", page = (int?)null },
                new { page = @"\d+" }
                );

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );

        }

        protected override void OnApplicationStarted()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
            RegisterAllControllersIn(Assembly.GetExecutingAssembly());
        }

        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new ServiceModule());
        }
    }
}