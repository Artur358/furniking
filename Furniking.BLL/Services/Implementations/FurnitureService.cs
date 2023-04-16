using AutoMapper;
using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;

namespace Furniking.BLL.Services.Implementations
{
    public class FurnitureService : IFurnitureService
    {

        private readonly int PAGE_SIZE = 20;

        private readonly IFurnitureRepository _furnitureRepository;
        private readonly ICategoryRepository _categoryRepository;

        private readonly IMapper _mapper;

        public FurnitureService(IFurnitureRepository furnitureRepository,
            ICategoryRepository categoryRepository,
            IMapper mapper)
        {
            _furnitureRepository = furnitureRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        public async Task<FurnitureDTO> CreateAsync(CreateFurnitureDTO furniture)
        {
            var m = _mapper.Map<Furniture>(furniture);
            
            if(await _categoryRepository.GetByIdAsync(m.CategoryId) == null)
            {
                throw new Exception();
            }

            var createdFurniture = await _furnitureRepository.AddAsync(m, f => f.Category);

            var r = await GetAsync(createdFurniture.Id);
            return r;
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
