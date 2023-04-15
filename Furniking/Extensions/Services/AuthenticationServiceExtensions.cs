using Furniking.BLL.AutoMapper.Profiles;
using Furniking.BLL.Factories.Implementations;
using Furniking.BLL.Factories.Interfaces;
using Furniking.BLL.Services.Implementations;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Furniking.Extensions.Services
{
    public static class AuthenticationServiceExtensions
    {
        public static void AddUserServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<User, IdentityRole<int>>(options =>
            {
                options.Password.RequireDigit = bool.Parse(configuration["User:Validation:Password:RequireDigit"]);
                options.Password.RequireLowercase = bool.Parse(configuration["User:Validation:Password:RequireLowercase"]);
                options.Password.RequireNonAlphanumeric = bool.Parse(configuration["User:Validation:Password:RequireNonAlphanumeric"]);
                options.Password.RequireUppercase = bool.Parse(configuration["User:Validation:Password:RequireUppercase"]);
                options.Password.RequiredLength = int.Parse(configuration["User:Validation:Password:RequiredLength"]);
                options.Password.RequiredUniqueChars = int.Parse(configuration["User:Validation:Password:RequiredUniqueChars"]);
            })
            .AddEntityFrameworkStores<DataContext>()
            .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["User:Jwt:Issuer"],
                    ValidAudience = configuration["User:Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["User:Jwt:SecretKey"]))
                };
            });

            services.AddAutoMapper(typeof(UserProfile));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IJwtFactory, JwtFactory>();
        }
    }
}
