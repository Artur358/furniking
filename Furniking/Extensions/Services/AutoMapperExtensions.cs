using Furniking.BLL.AutoMapper.Profiles;

namespace Furniking.Extensions.Services
{
    public static class AutoMapperExtensions
    {
        public static void AddAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserProfile));
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(typeof(FurnitureProfile));
            services.AddAutoMapper(typeof(OtherProfile));
        }
    }
}
 