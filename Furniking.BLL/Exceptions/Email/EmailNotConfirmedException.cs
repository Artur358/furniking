namespace Furniking.BLL.Exceptions.Email
{
    public class EmailNotConfirmedException : ApiException
    {
        public EmailNotConfirmedException(Dictionary<string, string> errors = null) : base(403, "Email is not confirmed", errors)
        {
        }
    }
}
