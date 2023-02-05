using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Homes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello this is get method");
    }
}
