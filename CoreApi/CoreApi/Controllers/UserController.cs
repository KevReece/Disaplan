using System.Web.Http;

namespace Disaplan.CoreApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok("Kev Reece");
        }
    }
}
