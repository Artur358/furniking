namespace Furniking.BLL.Exceptions.Authentication
{
    public class RoleNotSpecifiedException : ApiException
    {
        public RoleNotSpecifiedException() : base(500, "Role is not specified on the server")
        {
        }
    }
}
