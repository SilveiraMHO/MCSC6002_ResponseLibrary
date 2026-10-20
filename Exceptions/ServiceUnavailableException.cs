using System.Net;

namespace ResponseLibrary.Exceptions
{
    public class ServiceUnavailableException : Exception
    {
        public string FriendlyErrorMessage { get; set; }
        public List<string> ErrorMessages { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public ServiceUnavailableException(
            string friendlyErrorMessage,
            List<string> errorMessages = default,
            HttpStatusCode statusCode = HttpStatusCode.ServiceUnavailable)
        {
            ErrorMessages = errorMessages;
            FriendlyErrorMessage = friendlyErrorMessage;
            StatusCode = statusCode;
        }
    }
}
