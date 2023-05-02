namespace Furniking.BLL.Exceptions.Email
{
    public class IncorrectEmailExeption : ApiException
    {
        public IncorrectEmailExeption() : base(400, "The email is incorrect")
        {
        }
    }
}
