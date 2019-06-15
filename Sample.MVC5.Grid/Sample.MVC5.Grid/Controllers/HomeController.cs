using System.Linq;
using System.Web.Mvc;
using Sample.MVC5.Grid.Context;

namespace Sample.MVC5.Grid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult IndexGrid()
        {
            var people = PeopleRepository.GetPeople();
            return PartialView("IndexGrid", people.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}