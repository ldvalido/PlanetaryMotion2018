using System.Configuration;
using System.Web.Mvc;

namespace PlanetaryMotion.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ApiPrefix = ConfigurationManager.AppSettings["ApiPrefix"];
            return View();
        }
    }
}