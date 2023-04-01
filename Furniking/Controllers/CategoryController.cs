using Furniking.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Furniking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService service)
        {
            _categoryService = service;
        }

        [HttpGet("/Categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoryService.GetAllCategoryAsync());
        }
    }
}
