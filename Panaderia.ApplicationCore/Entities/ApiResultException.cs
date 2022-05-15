namespace Panaderia.ApplicationCore.Entities
{
    public class ApiResultException
    {
        public ApiResultException()
        {
            
        }

        public ApiResultException(string message, string source, string stackTrace)
        {
            Message = message;
            Source = source;
            StackTrace = stackTrace;
        }

        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
    }
}