namespace Furniking.BLL.DTOs.UserDTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool IsLocked { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
