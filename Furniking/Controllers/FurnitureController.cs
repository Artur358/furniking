using AutoMapper;
using Furniking.BLL.DTOs.CategoryDTOs;
using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.BLL.DTOs.ImageDTOs;
using Furniking.BLL.Exceptions;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Data;
using Furniking.DAL.Data.Helpers;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using Furniking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Furniking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnitureController : ControllerBase
    {
        private readonly IFurnitureService _furnitureService;
        private readonly IImageService _imageService;
        


        public FurnitureController(IFurnitureService furnitureService, IImageService imageService)
        {
            this._furnitureService = furnitureService;
            _imageService = imageService;
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] FurnitureViewModel furniture)
        {
            if (furniture.MainImage == null || furniture.MainImage.Length <= 0)
                throw new ApiException(400, "Main image is null or empty");

            if (!validateFileExtension(furniture.MainImage.FileName))
                throw new ApiException(400, "Extension incorrect");
            
            foreach (var file in furniture.formFiles)
            {
                if (!validateFileExtension(file.FileName))
                    throw new ApiException(400, "Extension incorrect");
            }

            var tasks = furniture.formFiles.Select(async (f) => await getImage(f) );

            var fdto = new CreateFurnitureDTO
            {
                CategoryId = furniture.CategoryId,
                Description = furniture.Description,
                Name = furniture.Name,
                Price = furniture.Price,
                Galery = await Task.WhenAll(tasks),
                MainImage = await getImage(furniture.MainImage)
            };

            var createdFurniture = await _furnitureService.CreateAsync(fdto);
            return Ok(createdFurniture);
        }


        private async Task<ImageDTO> getImage(IFormFile f)
        {
            using MemoryStream memoryStream = new MemoryStream();
            await f.CopyToAsync(memoryStream);
            var buffer = memoryStream.GetBuffer();

            return new ImageDTO()
            {
                Data = buffer,
                Name = f.Name,
                Extension = Path.GetExtension(f.FileName),
            };
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

        [HttpGet]
        public IActionResult Image(int id)
        {
            return Ok(_imageService.Get(id));
        }
     
        

        private bool validateFileExtension(string fileName)
        {
            return (new[] { ".jpg", ".png" }).Contains(Path.GetExtension(fileName));       
        }
    }
}
