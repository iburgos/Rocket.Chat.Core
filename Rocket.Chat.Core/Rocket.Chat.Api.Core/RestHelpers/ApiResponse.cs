using RestSharp;
using System.Net;

namespace Rocket.Chat.Api.Core.RestHelpers
{
    public class ApiResponse<T> : ApiResponse
    {
        public T Result { get; }

        public ApiResponse(HttpStatusCode statusCode, T result, string message = null)
            : base(statusCode, message)
        {
            Result = result;
        }

        public ApiResponse(HttpStatusCode statusCode, ResponseStatus responseStatus)
            : base(statusCode, responseStatus)
        {
        }
    }

    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; }
        public ResponseStatus ResponseStatus { get; set; }
        public string Message { get; }
        public string StackTrace { get; }
        public bool IsBusinessValidationMessage { get; set; }

        public ApiResponse(HttpStatusCode statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ApiResponse(HttpStatusCode statusCode, ResponseStatus responseStatus)
        {
            StatusCode = statusCode;
            ResponseStatus = responseStatus;
        }
    }
}
