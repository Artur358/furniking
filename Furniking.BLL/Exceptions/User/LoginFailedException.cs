namespace Furniking.BLL.Exceptions.User
{
    public class LoginFailedException : ApiException
    {
        public LoginFailedException() : base(403, "Incorrect email address or password")
        { }
    }
}
