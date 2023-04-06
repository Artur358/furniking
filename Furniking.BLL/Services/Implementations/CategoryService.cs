using AutoMapper;
using Furniking.BLL.DTOs.CategoryDTOs;
using Furniking.BLL.Exceptions;
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
            var actual = await _repository.AddAsync(_mapper.Map<Category>(dto));
            return _mapper.Map<CategoryInfoDTO>(actual);
        }

        public async Task<CategoryInfoDTO> EditAsync(EditCategoryDTO dto)
        {
            var category = _mapper.Map<Category>(dto);
            var actual = await _repository.UpdateAsync(category);
            return _mapper.Map<CategoryInfoDTO>(actual);
        }

        public async Task<IEnumerable<CategoryInfoDTO>> GetAllAsync()
        {
            var categories = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryInfoDTO>>(categories);
        }

        public async Task<CategoryInfoDTO> GetByIdAsync(int id)
        {
            var actual = await _repository.GetByIdAsync(id);

            if (actual == null)
                throw new IdIncorrectException();

            return _mapper.Map<CategoryInfoDTO>(actual);
        }

        public async Task RemoveByIdAsync(int id)
        {
            var result = await _repository.DeleteByIdAsync(id);
            
            if (result == false)
                throw new IdIncorrectException();
        }
    }
}
