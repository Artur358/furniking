using Furniking.BLL.DTOs.EmailDTOs;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendMailAsync(SendEmailDTO dto);
    }
}
