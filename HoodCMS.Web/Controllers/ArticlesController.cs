using System.Web.Mvc;
using HoodCMS.Data.Interfaces;

namespace HoodCMS.Web.Controllers
{
    public class ArticlesController : Controller
    {
        IArticleRepository articleRepo;

        public ArticlesController(IArticleRepository _articleRepo)
        {
            articleRepo = _articleRepo;
        }

        public ActionResult Index(int? page)
        {
            return View(articleRepo.GetPage(page));
        }

        public ActionResult GetNextThree()
        {
            return View("ShowArticles", articleRepo.GetNextThree());
        }
    }
}
