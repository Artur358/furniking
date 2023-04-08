using AutoMapper;
using Furniking.BLL.DTOs.CategoryDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;

namespace Furniking.BLL.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryInfoDTO> AddAsync(AddCategoryDTO dto)
        {
            var category = await _repository.AddAsync(_mapper.Map<Category>(dto));
            return _mapper.Map<CategoryInfoDTO>(category);
        }

        public async Task<IEnumerable<CategoryInfoDTO>> GetAllCategoryAsync()
        {
            var categories = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryInfoDTO>>(categories);
        }

        public async Task<CategoryInfoDTO?> GetByIdAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            return _mapper.Map<CategoryInfoDTO?>(category);
        }

        public async Task<bool> RemoveByIdAsync(int id)
        {
            return await _repository.DeleteByIdAsync(id);
        }
    }
}
