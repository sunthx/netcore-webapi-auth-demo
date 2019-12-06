using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace netcore_webapi_auth_demo.Controllers
{
    [Authorize]
    [Route("identity")]
    public class IdentityController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(User.Claims.Select(i => new {i.Type,i.Value}));
        }
    }
}
