using Microsoft.AspNetCore.Mvc;
using MyGardenPlanner.Server.BE.Authentification.Basic.Attributes;

namespace MyGardenPlanner.Server.BE.Controllers
{
    [Route("[controller]")]
    public class OAuthController : Controller
    {
        [HttpPost("token"), BasicAuthorization]
        public IActionResult Token()
        {
            return Ok();
        }
    }
}
