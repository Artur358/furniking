using AutoMapper;
using Furniking.BLL.DTOs.ImageDTOs;
using Furniking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.AutoMapper.Profiles
{
    public class OtherProfile : Profile
    {
        public OtherProfile() 
        {
            CreateMap<Image, ImageDTO>().ReverseMap();
        }

    }
}
