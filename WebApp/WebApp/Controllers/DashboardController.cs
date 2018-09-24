using System.Web.Mvc;
using Disaplan.WebApp.Apis;
using Disaplan.WebApp.Models;

namespace Disaplan.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly CoreApi coreApi;

        public DashboardController()
        {
            this.coreApi = new CoreApi();
        }

        public ActionResult Index()
        {
            var userId = "UserId";
            var userName = coreApi.GetUser(userId).Name;
            return View(new DashboardViewModel(userName));
        }
    }
}
