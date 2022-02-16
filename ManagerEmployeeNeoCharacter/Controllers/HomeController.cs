using System.Web.Mvc;
using ManagerEmployeeNeoCharacter.DAL;

namespace ManagerEmployeeNeoCharacter.Controllers
{
    public class HomeController : Controller
    {
        private ManagerEmployeeNeoCharacterContext db = new ManagerEmployeeNeoCharacterContext();
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
