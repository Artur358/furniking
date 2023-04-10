using Furniking.BLL.DTOs.User;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<TokenDTO> LoginAsync(AuthenticationDTO dto);
        Task<TokenDTO> RegistrationAsync(AuthenticationDTO dto);
        Task<UserDTO> GetByIdAsync(int id);
    }
}
