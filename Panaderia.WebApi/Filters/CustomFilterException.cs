using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Panaderia.ApplicationCore.Entities;
using Panaderia.ApplicationCore.Entities.Exception;

namespace Panaderia.WebApi.Filters
{
    public class CustomFilterException : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            ApiResult result = new ApiResult()
            {
                Error = true,
                Exception = new ApiResultException(
                    message: "Ha ocurrido un error. Comuniquese con su Administrador.", 
                    source: null, 
                    stackTrace: null)
            };

            var exceptionType = context.Exception.GetType();

            if (exceptionType == typeof(PanaderiaException))
            {
                var exception = (PanaderiaException)context.Exception;

                result.Exception.Message = exception.Message;
                result.Exception.Source = exception.Source;
                result.Exception.StackTrace = exception.StackTrace;
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            else
            {
                result.Exception.Source = context.Exception.Source;
                result.Exception.StackTrace = context.Exception.StackTrace;
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            context.ExceptionHandled = true;
            context.Result = new JsonResult(result);

            base.OnException(context);
        }
    }
}