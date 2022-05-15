using Panaderia.ApplicationCore.Entities.Exception;

namespace Panaderia.ApplicationCore.Entities
{
    public class ApiResult
    {
        public ApiResult()
        {
            
        }

        public ApiResult(bool error, ApiResultException panaderiaException, object? result)
        {
            Error = error;
            Exception = panaderiaException;
            Result = result;
        }

        public bool Error { get; set; }
        public ApiResultException Exception { get; set; }
        public object? Result { get; set; }
    }
}