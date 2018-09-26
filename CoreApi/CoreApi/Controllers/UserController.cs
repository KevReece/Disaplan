using System.Diagnostics;
using System.Web.Http;
using Disaplan.CoreApi.Models;

namespace Disaplan.CoreApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            Trace.TraceInformation($"Call to: {nameof(UserController)}.{nameof(Get)}(Id='{id}')");
            return Ok(new User{Name = "Kevster"});
        }
    }
}
