using FluentValidation;
using MyWorkout.Application.Common.Wrappers;
using System.Net;

namespace MyWorkout.Api.Middleware
{
    public class ErrorHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                var responseModel = ApiResponse<string>.Fail(GetInnerExceptionMessage(error));
                switch (error)
                {
                    case ValidationException ve:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }
                await response.WriteAsJsonAsync(responseModel);
            }
        }

        private string GetInnerExceptionMessage(Exception ex)
        {
            if (ex.InnerException is null)
            {
                return ex.Message;
            }

            return GetInnerExceptionMessage(ex.InnerException);
        }
    }
}
