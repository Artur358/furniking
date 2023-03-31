using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Furniking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationСontroller : ControllerBase
    {

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
