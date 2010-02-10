using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoodCMS.Data.Interfaces;
using HoodCMS.Web.ViewHelpers;

namespace HoodCMS.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Home home = new Home();
            home.Header = "Welcome to the Sunnyside United Neighbors, Inc. (HoodCMS) website, your source of information for everything you need to know about Northwest Denver's Sunnyside community. HoodCMS is made up of the residents, businesses and organizations from the neighborhood, and it's committed to making Sunnyside a great place to live. Visit the \"About HoodCMS\" page for more info.";
            return View(home);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
