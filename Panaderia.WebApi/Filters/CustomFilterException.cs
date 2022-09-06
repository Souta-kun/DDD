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
            ApiResult result = new ApiResult(
                error: new APIError(
                    message: "Ha ocurrido un error. Comuniquese con su Administrador.",
                    codeStatus: HttpStatusCode.InternalServerError,
                    stackTrace: context.Exception.StackTrace)
                );

            var exceptionType = context.Exception.GetType();

            if (exceptionType == typeof(PanaderiaException))
            {
                var exception = (PanaderiaException)context.Exception;
                result.Error.Message = exception.Message;
                result.Error.CodeStatus = exception.CodeStatus;

                context.HttpContext.Response.StatusCode = (int)exception.CodeStatus;
            }
            else
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            context.ExceptionHandled = true;
            context.Result = new JsonResult(result);

            base.OnException(context);
        }
    }
}