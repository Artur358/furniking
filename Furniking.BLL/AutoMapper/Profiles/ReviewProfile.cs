using AutoMapper;
using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.BLL.DTOs.ReviewDTOs;
using Furniking.DAL.Entities;

namespace Furniking.BLL.AutoMapper.Profiles
{
	public class ReviewProfile : Profile
	{
		public ReviewProfile()
		{
			CreateMap<Review, GetAllReviewDTO>()
				.ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
				.ForMember(dest => dest.FurnitureId, opt => opt.MapFrom(src => src.FurnitureId));
			CreateMap<Review, AddReviewDTO>().ReverseMap();
			CreateMap<Review, EditReviewDTO>().ReverseMap();
		}
	}
}
