using AutoMapper;
using Furniking.BLL.DTOs.CategoryDTOs;
using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Data;
using Furniking.DAL.Data.Helpers;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
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
        private readonly IMapper _mapper;


        public FurnitureController(IFurnitureService furnitureService, IMapper mapper = null)
        {
            this._furnitureService = furnitureService;
            _mapper = mapper;
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateFurnitureDTO furniture)
        {
            var createdFurniture = await _furnitureService.CreateAsync(furniture);
            return Ok(createdFurniture);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var f = await _furnitureService.GetAsync(id);
            return Ok(f);
        }


        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(FurnitureDTO furniture)
        {
            var updatedFurniture = await _furnitureService.EditAsync(furniture);
            return Ok(updatedFurniture);
        }


        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if( await _furnitureService.DeleteAsync(id))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("Page")]
        public async Task<IActionResult> Page(int page)
        {
            return Ok(await _furnitureService.GetPageAsync(page));
        }


     

    }
}
