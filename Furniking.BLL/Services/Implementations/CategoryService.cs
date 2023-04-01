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

        public async Task AddAsync(AddCategoryDTO dto)
        {
            await _repository.AddAsync(_mapper.Map<Category>(dto));
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

        public async Task RemoveByIdAsync(int id)
        {
            await _repository.DeleteByIdAsync(id);
        }
    }
}
