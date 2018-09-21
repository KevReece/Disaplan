using System.Web.Mvc;
using Disaplan.WebApp.Models;

namespace Disaplan.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View(new DashboardViewModel("blah"));
        }
    }
}
