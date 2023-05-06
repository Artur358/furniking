namespace Furniking.BLL.Exceptions.User
{
    public class RegistrationFailedException : ApiException
    {
        public RegistrationFailedException(Dictionary<string, string> errors) : base(403, "Registration failed", errors)
        { }
    }
}
