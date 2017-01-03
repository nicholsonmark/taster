using System.Web.Mvc;

namespace taster.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FirstAjax(string a)
        {
            return Json("chamara", JsonRequestBehavior.AllowGet);
        }

    }
}