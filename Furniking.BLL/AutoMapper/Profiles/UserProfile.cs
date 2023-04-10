using AutoMapper;
using Furniking.BLL.AutoMapper.Converters.UserConverters;
using Furniking.BLL.DTOs.User;
using Furniking.DAL.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace Furniking.BLL.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AuthenticationDTO, User>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(source => source.Email));

            CreateMap<User, UserDTO>()
                .ConvertUsing<UserToUserDTOConverter>();

            CreateMap<JwtSecurityToken, TokenDTO>()
                .ForMember(dest => dest.AccessToken, opt => opt.MapFrom(source => new JwtSecurityTokenHandler().WriteToken(source)))
                .ForMember(dest => dest.ExpireTo, opt => opt.MapFrom(source => source.ValidTo));
        }
    }
}
