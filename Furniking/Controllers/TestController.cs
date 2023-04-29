using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Furniking.Controllers
{


    public class IMG
    {
        public string Name { get; set; }

        [DataType(dataType: DataType.Upload)]
        public byte[] Data { get; set; }

    }


    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpPost]
        public IActionResult Test([FromForm] IMG img)
        {
            return Ok();
        }
    }
}
