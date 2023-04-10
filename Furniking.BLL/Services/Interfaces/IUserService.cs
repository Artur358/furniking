using Furniking.BLL.DTOs.User;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetByIdAsync(int id);
    }
}
