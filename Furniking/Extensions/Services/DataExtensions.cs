using Furniking.DAL.Data;
using Furniking.DAL.Repositories.Implementations;
using Furniking.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Furniking.Extensions.Services
{
    public static class DataExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IFurnitureRepository, FurnitureRepository>();
            //services.AddTransient<IUserTokenRepository, UserTokenRepository>();
        }

        public static void AddDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(op =>
            {
                op
                .UseLazyLoadingProxies()
                .UseSqlServer(configuration.GetConnectionString("devDB"));
            });
        }
    }
}
