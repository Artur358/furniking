using AutoMapper;
using Furniking.BLL.DTOs.UserDTOs;
using Furniking.BLL.Exceptions.Email;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Furniking.BLL.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<bool> IsEmailConfirmedAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                throw new IncorrectEmailExeption();

            return await _userManager.IsEmailConfirmedAsync(user);
        }
    }
}
