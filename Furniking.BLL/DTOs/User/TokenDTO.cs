namespace Furniking.BLL.DTOs.User
{
    public class TokenDTO
    {
        public string AccessToken { get; set; }
        public DateTime ExpireTo { get; set; }
    }
}
