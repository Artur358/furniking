using AutoMapper;
using Furniking.BLL.DTOs.User;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;

namespace Furniking.BLL.AutoMapper.Converters.User
{
    public class UserToUserDTOConverter : ITypeConverter<Furniking.DAL.Entities.User, UserDTO>
    {
        private readonly UserManager<Furniking.DAL.Entities.User> _userManager;

        public UserToUserDTOConverter(UserManager<DAL.Entities.User> userManager)
        {
            _userManager = userManager;
        }

        public UserDTO Convert(Furniking.DAL.Entities.User source, UserDTO destination, ResolutionContext context)
        {
            return new UserDTO
            {
                Id = source.Id,
                Email = source.Email,
                IsLocked = source.LockoutEnd != null && source.LockoutEnd > DateTime.UtcNow,
                LockoutEnd = source.LockoutEnd,
                Roles = _userManager.GetRolesAsync(source).Result
            };
        }
    }
}
