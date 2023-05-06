using Furniking.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Furniking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {

        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var image = await _imageService.Get(id);

            if(image == null || image.Data.Length <= 0)
            {
                return NotFound();
            }

            return new FileContentResult(image.Data, "image/jpeg");
        }
    }
}
