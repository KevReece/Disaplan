using System.Diagnostics;
using System.Web.Mvc;
using Disaplan.WebApp.Apis;
using Disaplan.WebApp.Models;

namespace Disaplan.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly CoreApi coreApi;

        public DashboardController(CoreApi coreApi)
        {
            this.coreApi = coreApi;
        }

        public ActionResult Index()
        {
            var userId = "UserId";
            Trace.TraceInformation($"Call to: {nameof(DashboardController)}.{nameof(Index)}{{UserId='{userId}'}}");
            var userName = coreApi.GetUser(userId).Name;
            return View(new DashboardViewModel(userName));
        }
    }
}
