using Furniking.BLL.Services.Implementations;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Repositories.Implementations;
using Furniking.DAL.Repositories.Interfaces;

namespace Furniking.Extensions
{
    internal static class ServicesRegistration
    {
        public static IServiceCollection ServicesRegister(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IFurnitureService, FurnitureService>();
			services.AddTransient<IReviewService, ReviewService>();
            return services;
        }
    }
}
