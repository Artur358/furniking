using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Furniking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnitureController : ControllerBase
    {
        private readonly IFurnitureService _furnitureService;
        private readonly DataContext dataContext;

        public FurnitureController(IFurnitureService furnitureService, DataContext dataContext)
        {
            this._furnitureService = furnitureService;
            this.dataContext = dataContext;
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateFurnitureDTO furniture)
        {
            _ = furniture;
            var createdFurniture = await _furnitureService.CreateAsync(furniture);
            return Ok(createdFurniture);
        }


        [HttpGet]
        public IActionResult Test()
        {

            dataContext.Testing();
            //foreach (var item in dataContext.Furnitures.Include(f => f.Category) )
            //{
            //    _ = item;
            //    var cat = item.Category;
            //    _ = cat;
            //}

            return Ok();
        }

        
    }
}
