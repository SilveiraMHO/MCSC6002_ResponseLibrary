using System.Net;

namespace ResponseLibrary.Exceptions
{
    internal class CustomValidationException : Exception
    {
        public string FriendlyErrorMessage { get; set; }
        public List<string> ErrorMessages { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public CustomValidationException(
            string friendlyErrorMessage,
            List<string> errorMessages = default,
            HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            ErrorMessages = errorMessages;
            FriendlyErrorMessage = friendlyErrorMessage;
            StatusCode = statusCode;
        }
    }
}
