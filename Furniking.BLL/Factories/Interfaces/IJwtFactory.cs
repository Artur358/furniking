using Furniking.DAL.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace Furniking.BLL.Factories.Interfaces
{
    public interface IJwtFactory
    {
        Task<JwtSecurityToken> CreateJwtTokenAsync(User user);
    }
}
