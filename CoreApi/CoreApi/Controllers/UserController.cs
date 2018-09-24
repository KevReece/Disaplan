using System.Web.Http;
using Disaplan.CoreApi.Models;

namespace Disaplan.CoreApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(new User{Name = "Kevster"});
        }
    }
}
