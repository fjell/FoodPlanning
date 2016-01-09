using System.Web.Mvc;

namespace FoodPlanning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}