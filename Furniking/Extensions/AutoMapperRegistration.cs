using Furniking.BLL.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.Extensions
{
    internal static class AutoMapperRegistration
    {
        public static IServiceCollection AutoMapperProfilesRegister(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryProfile));
            services.AddAutoMapper(typeof(FurnitureProfile));
            return services;
        }
    }
}
