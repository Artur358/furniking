namespace Furniking.BLL.Exceptions.User
{
    public class RoleNotSpecifiedException : Exception
    {
        public RoleNotSpecifiedException() : base("Role is not specified on the server")
        {
        }
    }
}
