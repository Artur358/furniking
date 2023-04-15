using Furniking.BLL.DTOs.CategoryDTOs;
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
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _categoryService.GetAllAsync());
        }

        [HttpGet("/Category/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            if (category == null)
                return BadRequest();

            return Ok(category);
        }

        [HttpPost("/Category/Add")]
        public async Task<IActionResult> Add(AddCategoryDTO dto)
        {
            // при невдалому додавані кинеться помилка DbUpdateException
            return Ok(await _categoryService.AddAsync(dto));
        }

        [HttpPost("/Category/Edit")]
        public async Task<IActionResult> Edit(EditCategoryDTO dto)
        {
            // при невдалому додавані кинеться помилка DbUpdateException
            return Ok(await _categoryService.EditAsync(dto));
        }

        [HttpPost("/Category/Remove/{id}")]
        public async Task<IActionResult> RemoveById(int id)
        {
            var result = await _categoryService.RemoveByIdAsync(id);
            return result ? Ok() : BadRequest();
        }
    }
}

