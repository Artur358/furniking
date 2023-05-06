using Furniking.Extensions.Middlewares;
using Furniking.Extensions.Services;

namespace Furniking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // DAL
            builder.Services.AddDataContext(builder.Configuration);
            builder.Services.AddRepositories(); // TODO: Use IUnitOfWork

            // BLL
            builder.Services.AddConfiguratedAuthentication(builder.Configuration);
            builder.Services.AddServices();
            builder.Services.AddConfigurationOptions(builder.Configuration);
            builder.Services.AddAutoMapperProfiles();

            // Web
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddConfiguratedSwagger();

            var app = builder.Build();
            // Configure the HTTP request pipeline.

            if (app.Environment.IsProduction())
            {
                app.UseCustomExceptionHandler();
            }

            app.UseSwagger();
            app.UseSwaggerUI();

            //app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}                                                