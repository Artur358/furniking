using Furniking.BLL.DTOs.UserDTOs;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetByIdAsync(int id);
        Task<bool> IsEmailConfirmedAsync(string email);
    }
}
