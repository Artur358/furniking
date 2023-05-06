using Furniking.BLL.AutoMapper.Profiles;
using Furniking.BLL.TokenProviders;
using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.ValidationConstants.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Furniking.Extensions.Services
{
    public static class AuthenticationExtensions
    {
        public static void AddConfiguratedAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<User, IdentityRole<int>>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = null;

                options.Lockout.MaxFailedAccessAttempts = UserValidationConstants.MaxFailedAccessAttempts;
                options.Lockout.DefaultLockoutTimeSpan = UserValidationConstants.DefaultLockoutTimeSpan;

                options.Password.RequiredLength = UserValidationConstants.PasswordRequiredLength;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;

                options.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
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
        }
    }
}
