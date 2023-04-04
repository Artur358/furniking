using Furniking.BLL.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net.Mail;
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

                    var statusCode = StatusCodes.Status500InternalServerError;
                    if (exception.Error is ApiException apiException)
                        statusCode = apiException.StatusCode;

                    context.Response.StatusCode = statusCode;
                    context.Response.ContentType = "application/json";

                    await context.Response.WriteAsync(JsonSerializer.Serialize(new
                    {
                        StatusCode = statusCode,
                        Message = exception.Error.Message
                    }));
                });
            });
        }
    }
}
