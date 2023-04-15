using Furniking.BLL.AutoMapper.Profiles;

namespace Furniking.Extensions
{
	internal static class AutoMapperRegistration
	{
		public static IServiceCollection AutoMapperProfilesRegister(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(CategoryProfile));
			services.AddAutoMapper(typeof(ReviewProfile));
			return services;
		}
	}
}
