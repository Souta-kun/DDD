using System.Net;
using Panaderia.ApplicationCore.Entities.Exception;

namespace Panaderia.ApplicationCore.Entities
{
    public class ApiResult
    {
        public ApiResult(APIError error = null, object? result = null)
        {
            Error = error;
            Result = result;
        }

        public APIError Error { get; set; }
        public object? Result { get; set; }
    }

    public class APIError 
    {
        public APIError(int? traceId = null, HttpStatusCode? codeStatus = null, string? message = null, string? stackTrace = null)
        {
            TraceId = traceId;
            CodeStatus = codeStatus;
            Message = message;
            StackTrace = stackTrace;
        }

        public int? TraceId { get; set; }
        public HttpStatusCode? CodeStatus { get; set; }
        public string? Message { get; set; }
        public string? StackTrace { get; set; }
    }
}