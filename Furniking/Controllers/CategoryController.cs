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

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _categoryService.GetAllAsync());
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return Ok(category);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddCategoryDTO dto)
        {
            // при невдалому додавані кинеться помилка DbUpdateException
            return Ok(await _categoryService.AddAsync(dto));
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(EditCategoryDTO dto)
        {
            // при невдалому додавані кинеться помилка DbUpdateException
            return Ok(await _categoryService.EditAsync(dto));
        }

        [HttpDelete("Remove/{id}")]
        public async Task<IActionResult> RemoveById(int id)
        {
            await _categoryService.RemoveByIdAsync(id);
            return Ok();
        }
    }
}

