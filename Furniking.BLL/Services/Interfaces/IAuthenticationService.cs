using Furniking.BLL.DTOs.User;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<TokenDTO> LoginAsync(AuthenticationDTO dto);
        Task<TokenDTO> RegistrationAsync(AuthenticationDTO dto);
    }
}
