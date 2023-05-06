using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Furniking.DAL.Data.Extensions.ModelBuilderExtensions
{
    public static class RoleExtension
    {
        public static void LoadRoles(this ModelBuilder builder, IEnumerable<string> roles)
        {
            var entities = new List<IdentityRole<int>>();
            int actualId = 1;

            foreach (var role in roles)
                entities.Add(new IdentityRole<int>(role) { Id = actualId++, NormalizedName = role.ToUpper() });

            builder.Entity<IdentityRole<int>>().HasData(entities);
        }
    }
}
