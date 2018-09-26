using System.Diagnostics;
using System.Web.Mvc;

namespace Disaplan.WebApp.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            Trace.TraceInformation($"Call to: {nameof(IndexController)}.{nameof(Index)}");
            return View();
        }
    }
}