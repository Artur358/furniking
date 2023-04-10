using AutoMapper;
using Furniking.BLL.DTOs.CategoryDTOs;
using Furniking.DAL.Entities;

namespace Furniking.BLL.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryInfoDTO>()
                .ReverseMap();
            CreateMap<AddCategoryDTO, Category>();
        }
    }
}
