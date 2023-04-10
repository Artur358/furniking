namespace Furniking.BLL.Exceptions.Authentication
{
    public class RegistrationFailedException : ApiException
    {
        public RegistrationFailedException(string error) : base(403, error)
        { }
    }
}
