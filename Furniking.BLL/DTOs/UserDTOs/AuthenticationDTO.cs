using Furniking.DAL.ValidationConstants.User;
using System.ComponentModel.DataAnnotations;

namespace Furniking.BLL.DTOs.UserDTOs
{
    public class AuthenticationDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(UserValidationConstants.PasswordRequiredLength)]
        public string Password { get; set; }
    }
}
