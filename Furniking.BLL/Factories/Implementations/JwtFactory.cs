using Furniking.BLL.Factories.Interfaces;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Furniking.BLL.Factories.Implementations
{
    public class JwtFactory : IJwtFactory
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;

        public JwtFactory(IConfiguration configuration, UserManager<User> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<JwtSecurityToken> CreateJwtTokenAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var claims = await GetClaimsAsync(user);

            var key = _configuration["User:Jwt:SecretKey"];
            var issuer = _configuration["User:Jwt:Issuer"];
            var audience = _configuration["User:Jwt:Audience"];
            var days = _configuration["User:Jwt:ExpireDays"];

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(Convert.ToDouble(days)),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                    SecurityAlgorithms.HmacSha256Signature)
                );
            return jwt;
        }

        private async Task<IEnumerable<Claim>> GetClaimsAsync(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
            };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }
    }
}
