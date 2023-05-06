using AutoMapper;
using Furniking.BLL.DTOs.EmailDTOs;
using Furniking.BLL.DTOs.UserDTOs;
using Furniking.BLL.Exceptions;
using Furniking.BLL.Exceptions.Email;
using Furniking.BLL.Exceptions.User;
using Furniking.BLL.Factories.Interfaces;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Furniking.BLL.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly IJwtFactory _jwtFactory;
        private readonly IEmailService _emailService;
        private readonly IUserService _userService;
        private readonly ConfigurationOptions.UserOptions _options;

        public AuthenticationService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, IJwtFactory jwtFactory, IEmailService emailService, IOptions<ConfigurationOptions.UserOptions> options, IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _jwtFactory = jwtFactory;
            _emailService = emailService;
            _options = options.Value;
            _userService = userService;
        }

        public async Task<TokenDTO> LoginAsync(AuthenticationDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                throw new LoginFailedException();

            var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (result.Succeeded == false)
                throw new LoginFailedException();

            var emailConfirmed = await _userService.IsEmailConfirmedAsync(user.Email);
            if (emailConfirmed == false)
                throw new EmailNotConfirmedException();

            var token = await _jwtFactory.CreateJwtTokenAsync(user);
            return _mapper.Map<TokenDTO>(token);
        }

        public async Task RegistrationAsync(AuthenticationDTO dto)
        {
            ArgumentNullException.ThrowIfNull(dto);

            var user = _mapper.Map<User>(dto);

            var result = await _userManager.CreateAsync(user, dto.Password);
            if (result.Succeeded == false)
                throw new RegistrationFailedException(result.Errors.ToDictionary(k => k.Code, v => v.Description));

            await _userManager.AddToRoleAsync(user,
                _options.DefaultRole ?? throw new RoleNotSpecifiedException());
        }

        public async Task SendMailForConfirmEmailAsync(string email)
        {
            if (await _userService.IsEmailConfirmedAsync(email) == true)
                throw new EmailAlreadyConfirmedException();

            var user = await _userManager.FindByEmailAsync(email);
            var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            await _emailService.SendMailAsync(new SendEmailDTO
            {
                TargetEmail = user.Email,
                Subject = "Confirm email | Furniture shop",
                Html = "Confirmation token: " + emailToken
            });
        }

        public async Task ConfirmEmailAsync(string email, string token)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                throw new IncorrectEmailExeption();

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded == false)
                throw new EmailNotConfirmedException(result.Errors.ToDictionary(k => k.Code, v => v.Description));
        }
    }
}
