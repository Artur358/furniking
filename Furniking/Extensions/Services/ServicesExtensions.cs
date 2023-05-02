using Furniking.BLL.Factories.Implementations;
using Furniking.BLL.Factories.Interfaces;
using Furniking.BLL.Services.Implementations;
using Furniking.BLL.Services.Interfaces;

namespace Furniking.Extensions.Services
{
    public static class ServicesExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.addUserServices();
            services.addEmailServices();
            services.addCategoryServices();
            services.addFurnitureServices();
        }

        private static void addUserServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IJwtFactory, JwtFactory>();
        }

        private static void addEmailServices(this IServiceCollection services)
        {
            services.AddTransient<IEmailService, EmailService>();
        }

        private static void addCategoryServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
        }

        private static void addFurnitureServices(this IServiceCollection services)
        {
            services.AddTransient<IFurnitureService, FurnitureService>();
        }
    }
}
