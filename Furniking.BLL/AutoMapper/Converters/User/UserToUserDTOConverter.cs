using AutoMapper;
using Furniking.BLL.DTOs.User;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Furniking.BLL.AutoMapper.Converters.UserConverters
{
    public class UserToUserDTOConverter : ITypeConverter<User, UserDTO>
    {
        private readonly UserManager<User> _userManager;

        public UserToUserDTOConverter(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public UserDTO Convert(User source, UserDTO destination, ResolutionContext context)
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
