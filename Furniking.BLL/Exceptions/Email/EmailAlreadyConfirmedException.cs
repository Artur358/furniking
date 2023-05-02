namespace Furniking.BLL.Exceptions.Email
{
    public class EmailAlreadyConfirmedException : ApiException
    {
        public EmailAlreadyConfirmedException() : base(400, "Email already confirmed")
        {
        }
    }
}
