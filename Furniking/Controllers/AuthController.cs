using Furniking.BLL.DTOs.UserDTOs;
using Furniking.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;

namespace Furniking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IEmailService _emailService;

        public AuthController(IUserService userService, IAuthenticationService authenticationService, IEmailService emailService)
        {
            _userService = userService;
            _authenticationService = authenticationService;
            _emailService = emailService;
        }

        [HttpPost("Login")]
        [SwaggerResponse(200, Type = typeof(TokenDTO))]
        [SwaggerResponse(403, Description = "Login is failed! Email or password invalid.")]
        public async Task<IActionResult> Login([FromBody] AuthenticationDTO dto)
        {
            return Ok(await _authenticationService.LoginAsync(dto));
        }

        [HttpPost("Registration")]
        [SwaggerResponse(200, Type = typeof(TokenDTO))]
        [SwaggerResponse(403, Description = "Registration is failed! Email or password invalid.")]
        [SwaggerResponse(500, Description = "Role is not specified on the server!")]
        public async Task<IActionResult> Registration([FromBody] AuthenticationDTO dto)
        {
            await _authenticationService.RegistrationAsync(dto);
            return Ok();
        }

        [Authorize]
        [HttpGet("GetLoginedUser")]
        [SwaggerResponse(200, Type = typeof(UserDTO))]
        [SwaggerResponse(401, Description = "User is not logined")]
        public async Task<IActionResult> GetLoginedUser()
        {
            var userId = int.Parse(User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _userService.GetByIdAsync(userId));
        }

        [HttpPost("SendMailToConfirmEmail")]
        public async Task<IActionResult> SendMail(string email)
        {
            await _authenticationService.SendMailForConfirmEmailAsync(email);
            return Ok();
        }

        [HttpPost("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string email, string token)
        {
            await _authenticationService.ConfirmEmailAsync(email, token);
            return Ok();
        }
    }
}
