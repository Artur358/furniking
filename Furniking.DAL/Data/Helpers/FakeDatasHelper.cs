using Bogus;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Furniking.DAL.Data.Helpers
{
    public static class FakeDatasHelper
    {
        private const int CATEGORIES_COUNT = 6;
        private const int FURNITURE_COUNT = 50;
        private const int REVIEW_COUNT = 60;

        private const string LOCALE = "en";

        public static void LoadToDb(ModelBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            var categories = LoadFakeCategories(builder);
            var furnitures = LoadFakeFurniture(builder, categories);
            LoadFakeRoles(builder);
            var users = LoadFakeUsers(builder);
            LoadFakeRewiews(builder, users, furnitures);
        }

        private static IEnumerable<Category> LoadFakeCategories(ModelBuilder builder)
        {
            var faker = new Faker<Category>(LOCALE)
                .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                .RuleFor(x => x.Name, f => f.Commerce.Department());

            return LoadDatasToDb(builder.Entity<Category>(), faker.Generate(CATEGORIES_COUNT));
        }

        private static IEnumerable<Furniture> LoadFakeFurniture(ModelBuilder builder, IEnumerable<Category> categories)
        {
            var faker = new Faker<Furniture>(LOCALE)
                .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                .RuleFor(x => x.Description, f => f.Lorem.Paragraph())
                .RuleFor(x => x.Price, f => f.Random.Decimal(10, 1000))
                .RuleFor(x => x.CategoryId, f => f.PickRandom(categories).Id);

            return LoadDatasToDb(builder.Entity<Furniture>(), faker.Generate(FURNITURE_COUNT));
        }

        private static void LoadFakeRoles(ModelBuilder builder)
        {
            LoadDatasToDb(builder.Entity<IdentityRole<int>>(), new[] 
            {
                new IdentityRole<int>("User") { Id = 1, NormalizedName = "USER" },
                new IdentityRole<int>("Moderator") { Id = 2, NormalizedName = "MODERATOR" },
                new IdentityRole<int>("Admin") { Id = 3, NormalizedName = "ADMIN" },
            });
        }

        private static IEnumerable<User> LoadFakeUsers(ModelBuilder builder)
        {
            var user = new User()
            {
                Id = 1,
                UserName = "user@gmail.com",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                NormalizedUserName = "USER@GMAIL.COM",
            };
            var moderator = new User()
            {
                Id = 2,
                UserName = "moderator@gmail.com",
                Email = "moderator@gmail.com",
                NormalizedEmail = "MODERATOR@GMAIL.COM",
                NormalizedUserName = "MODERATOR@GMAIL.COM",
            };
            var admin = new User()
            {
                Id = 3,
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN@GMAIL.COM",
            };

            const string PASSWORD = "password";

            user.PasswordHash = new PasswordHasher<User>().HashPassword(user, PASSWORD);
            moderator.PasswordHash = new PasswordHasher<User>().HashPassword(moderator, PASSWORD);
            admin.PasswordHash = new PasswordHasher<User>().HashPassword(admin, PASSWORD);

            LoadDatasToDb(builder.Entity<IdentityUserRole<int>>(), new[]
            {
                new IdentityUserRole<int>() { UserId = 1, RoleId = 1 },
                new IdentityUserRole<int>() { UserId = 2, RoleId = 2 },
                new IdentityUserRole<int>() { UserId = 3, RoleId = 3 },
            });

            return LoadDatasToDb(builder.Entity<User>(), new[]
            {
                user,
                moderator,
                admin,
            });
        }

        private static void LoadFakeRewiews(ModelBuilder builder, IEnumerable<User> users, IEnumerable<Furniture> furnitures)
        {
            var faker = new Faker<Review>(LOCALE)
                .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                .RuleFor(x => x.Comment, f => f.Lorem.Paragraph())
                .RuleFor(x => x.Evaluation, f => f.Random.Int(1, 11))
                .RuleFor(x => x.DateTime, f => DateTime.UtcNow)
                .RuleFor(x => x.UserId, f => f.PickRandom(users).Id)
                .RuleFor(x => x.FurnitureId, f => f.PickRandom(furnitures).Id);

            LoadDatasToDb(builder.Entity<Review>(), faker.Generate(REVIEW_COUNT));
        }

        private static IEnumerable<TEntity> LoadDatasToDb<TEntity>(EntityTypeBuilder<TEntity> typeBuilder, IEnumerable<TEntity> entities)
            where TEntity : class
        {
            typeBuilder.HasData(entities);
            return entities;
        }
    }
}
