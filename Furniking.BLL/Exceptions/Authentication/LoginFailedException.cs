namespace Furniking.BLL.Exceptions.Authentication
{
    public class LoginFailedException : ApiException
    {
        public LoginFailedException() : base(403, "Login is failed")
        { }
    }
}
