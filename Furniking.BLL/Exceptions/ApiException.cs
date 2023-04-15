namespace Furniking.BLL.Exceptions
{
    public class ApiException : Exception
    {
        public int StatusCode { get; set; }
        public Dictionary<string, string>? Errors { get; set; }

        public ApiException(int statusCode, string title, Dictionary<string, string>? errors = null) : base(title)
        {
            StatusCode = statusCode;
            Errors = errors;
        }
    }
}
