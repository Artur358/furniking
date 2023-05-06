using Furniking.BLL.DTOs.UserDTOs;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<TokenDTO> LoginAsync(AuthenticationDTO dto);
        Task RegistrationAsync(AuthenticationDTO dto);
        Task SendMailForConfirmEmailAsync(string email);
        Task ConfirmEmailAsync(string email, string token);
    }
}
