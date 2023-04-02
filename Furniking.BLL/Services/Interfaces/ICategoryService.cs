﻿using Furniking.BLL.DTOs.CategoryDTOs;

namespace Furniking.BLL.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryInfoDTO>> GetAllCategoryAsync();
        Task<CategoryInfoDTO?> GetByIdAsync(int id);
        Task<CategoryInfoDTO> AddAsync(AddCategoryDTO dto);
        Task<bool> RemoveByIdAsync(int id);
    }
}
