namespace Furniking.BLL.Exceptions.Authentication
{
    public class LoginFailedException : ApiException
    {
        public LoginFailedException() : base(403, "Incorrect email address or password")
        { }
    }
}
