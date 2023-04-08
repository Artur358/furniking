using AutoMapper;
using Furniking.BLL.DTOs.ReviewDTOs;
using Furniking.DAL.Entities;

namespace Furniking.BLL.AutoMapper.Profiles
{
	public class ReviewProfile : Profile
	{
		public ReviewProfile()
		{
			CreateMap<AddReviewDTO, Review>();
		}
	}
}
