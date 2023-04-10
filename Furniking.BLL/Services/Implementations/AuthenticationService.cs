using AutoMapper;
using Furniking.BLL.DTOs.User;
using Furniking.BLL.Exceptions.Authentication;
using Furniking.BLL.Factories.Interfaces;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Furniking.BLL.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IJwtFactory _jwtFactory;

        public AuthenticationService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, IConfiguration configuration, IJwtFactory jwtFactory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _configuration = configuration;
            _jwtFactory = jwtFactory;
        }

        public async Task<TokenDTO> LoginAsync(AuthenticationDTO dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                throw new LoginFailedException();

            var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (result.Succeeded == false)
                throw new LoginFailedException();

            var token = await _jwtFactory.CreateJwtTokenAsync(user);
            return _mapper.Map<TokenDTO>(token);
        }

        public async Task<TokenDTO> RegistrationAsync(AuthenticationDTO dto)
        {
            var user = _mapper.Map<User>(dto);

            var result = await _userManager.CreateAsync(user, dto.Password);
            if (result.Succeeded == false)
                throw new RegistrationFailedException(String.Join(", ", result.Errors.Select(e => e.Code)) ?? "RegistrationError");

            await _userManager.AddToRoleAsync(user,
                _configuration["User:DefaultRole"] ?? throw new RoleNotSpecifiedException());

            var token = await _jwtFactory.CreateJwtTokenAsync(user);
            return _mapper.Map<TokenDTO>(token);
        }
    }
}
