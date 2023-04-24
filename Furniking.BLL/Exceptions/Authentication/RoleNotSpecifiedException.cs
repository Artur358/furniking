namespace Furniking.BLL.Exceptions.Authentication
{
    public class RoleNotSpecifiedException : Exception
    {
        public RoleNotSpecifiedException() : base("Role is not specified on the server")
        {
        }
    }
}
