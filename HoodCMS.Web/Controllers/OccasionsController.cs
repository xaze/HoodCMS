using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using HoodCMS.Data.Interfaces;

namespace HoodCMS.Web.Controllers
{
    public class OccasionsController : Controller
    {
        IOccasionRepository occasionsRepo;

        public OccasionsController(IOccasionRepository _occasionsRepo)
        {
            occasionsRepo = _occasionsRepo;
        }

        public ActionResult Index(int? page)
        {
            return View(occasionsRepo.GetPage(page));
        }

        public ActionResult GetNextThree()
        {
            return View("ShowOccasions", occasionsRepo.GetNextThree());
        }
    }
}
