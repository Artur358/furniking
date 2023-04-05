﻿using AutoMapper;
using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.AutoMapper.Profiles
{
    public class FurnitureProfile : Profile
    {
        public FurnitureProfile() 
        {
            CreateMap<Furniture, FurnitureDTO>()
                .ForMember(
                    dest => dest.ImagesId,
                    opt => opt.MapFrom(f => f.Images.Select(i => i.Id))
                )
                .ForMember(
                    dest => dest.ReviewsId,
                    opt => opt.MapFrom(f => f.Reviews.Select(r => r.Id))
                )
                .ReverseMap();

            CreateMap<Furniture, CreateFurnitureDTO>().ReverseMap();
                
        }
    }
}
