using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Furniking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> repository;

        public CategoryController(IRepository<Category> repository)  
        {
            this.repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAction(int id)
        {
            var res = await repository.GetByIdAsync(id);
            return Ok(res.Name);
        }

    }
}
