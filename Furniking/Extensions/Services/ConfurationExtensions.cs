using Furniking.BLL.ConfigurationOptions;

namespace Furniking.Extensions.Services
{
    public static class ConfurationExtensions
    {
        public static void AddConfigurationOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<UserOptions>(configuration.GetSection("User"));
            services.Configure<MailOptions>(configuration.GetSection("MailSettings"));
        }
    }
}
