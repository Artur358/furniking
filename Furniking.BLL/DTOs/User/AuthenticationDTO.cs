using System.ComponentModel.DataAnnotations;

namespace Furniking.BLL.DTOs.User
{
    public class AuthenticationDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
