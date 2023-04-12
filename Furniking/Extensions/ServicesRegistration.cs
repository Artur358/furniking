using Furniking.BLL.Services.Implementations;
using Furniking.BLL.Services.Interfaces;

namespace Furniking.Extensions
{
    internal static class ServicesRegistration
    {
        public static IServiceCollection ServicesRegister(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IFurnitureService, FurnitureService>();
            services.AddTransient<IImageService, ImageService>();
            return services;
        }
    }
}
