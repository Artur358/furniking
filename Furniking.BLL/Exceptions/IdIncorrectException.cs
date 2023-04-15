namespace Furniking.BLL.Exceptions
{
    public class IdIncorrectException : ApiException
    {
        public IdIncorrectException() : base(400, "The id is incorrect")
        { }
    }
}
