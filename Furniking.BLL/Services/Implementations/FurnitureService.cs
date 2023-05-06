using AutoMapper;
using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.BLL.DTOs.ImageDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Furniking.BLL.Services.Implementations
{
    public class FurnitureService : IFurnitureService
    {

        private readonly int PAGE_SIZE = 20;

        private readonly IFurnitureRepository _furnitureRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IImageService _imageService;

        private readonly IMapper _mapper;

        public FurnitureService(IFurnitureRepository furnitureRepository,
            ICategoryRepository categoryRepository,
            IMapper mapper,
            IImageService imageService)
        {
            _furnitureRepository = furnitureRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _imageService = imageService;
        }


        public async Task<FurnitureDTO> CreateAsync(CreateFurnitureDTO furniture)
        {
            if(await _categoryRepository.GetByIdAsync(furniture.CategoryId) == null)
                throw new Exception("Incorrect categoryId");

            var m = _mapper.Map<Furniture>(furniture);


            var createdFurniture = await _furnitureRepository.AddAsync(m);
            _ = createdFurniture;
            return _mapper.Map<FurnitureDTO>(createdFurniture);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _furnitureRepository.DeleteByIdAsync(id);
        }

        public async Task<FurnitureDTO> EditAsync(FurnitureDTO furniture)
        {
            if(await _categoryRepository.GetByIdAsync(furniture.Category.Id) == null)
                throw new Exception();

            var f = await _furnitureRepository.UpdateAsync(_mapper.Map<Furniture>(furniture));
            
            return _mapper.Map<FurnitureDTO>(f);
        }

        public async Task<IList<FurnitureDTO>> GetAllAsync()
        {
            return _mapper.Map<IList<FurnitureDTO>>(await _furnitureRepository.GetAllAsync());
        }

        public async Task<FurnitureDTO> GetAsync(int id)
        {
            var f = await _furnitureRepository.GetByIdAsync(id);
            if (f == null)
                throw new Exception();
            
            return _mapper.Map<FurnitureDTO>(f);
        }

        public async Task<FurniturePageDTO> GetPageAsync(int page)
        {
            var totalCount = await _furnitureRepository.CountAsync();
            var pageCount = (int)Math.Ceiling((double)totalCount / PAGE_SIZE);

            if (page <= 0) 
                page = 1;
            
            var pageList = await _furnitureRepository.GetPageAsync(page, PAGE_SIZE);

            return new FurniturePageDTO()
            {
                Page = page,
                PageCount = pageCount,
                TotalCount = totalCount,
                Furnitures = pageList.Select(f => _mapper.Map<FurnitureDTO>(f)).ToList()
            };
              
        }

    }
}
