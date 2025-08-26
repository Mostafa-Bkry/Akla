namespace Akla.Services
{
    public class CustomException : Exception
    {
        public CustomException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
