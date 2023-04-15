using Furniking.BLL.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Diagnostics;
using System.Text.Json;

namespace Furniking.Extensions.Middlewares
{
    public static class ExceptionHandlerExtension
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    var exception = context.Features.Get<IExceptionHandlerFeature>();
                    if (exception == null)
                        return;

                    dynamic responce;
                    if (exception.Error is ApiException apiException)
                        responce = GetApiExceptionResponce(apiException, context);
                    else
                        responce = GetServerErrorResponce(exception.Error, context);

                    context.Response.StatusCode = responce.Status;
                    context.Response.ContentType = "application/json";

                    string json = JsonSerializer.Serialize(responce);
                    await context.Response.WriteAsync(json);
                });
            }); 
        }

        private static dynamic GetApiExceptionResponce(ApiException exception, HttpContext context)
        {
            return new
            {
                Type = exception.GetType().Name,
                Title = exception.Message,
                Status = exception.StatusCode,
                TraceId = Activity.Current?.Id ?? context?.TraceIdentifier,
                Errors = exception.Errors,
            };
        }

        private static dynamic GetServerErrorResponce(Exception exception, HttpContext context)
        {
            return new
            {
                Type = exception.GetType().Name,
                Title = exception.Message,
                Status = StatusCodes.Status500InternalServerError,
                TraceId = Activity.Current?.Id ?? context?.TraceIdentifier,
            };
        }
    }
}
