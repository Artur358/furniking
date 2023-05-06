using Bogus;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Furniking.DAL.Data.Extensions.ModelBuilderExtensions
{
    public static class FakeDatasExtension
    {
        private const int CATEGORIES_COUNT = 6;
        private const int FURNITURE_COUNT = 50;
        private const int REVIEW_COUNT = 60;
        private const int ORDER_COUNT = 30;

        private const string LOCALE = "en";
        private const int SEED = 12345; // don't change this parameter unless you want to change all the fake data when adding the next migration

        private static readonly DateTime _defaultDateTime = new DateTime(2023, 4, 17);

        private static ModelBuilder _builder; // created this field because there is only one public method

        public static void LoadFakeDatas(this ModelBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            _builder = builder;

            var categories = LoadFakeCategories();
            var furnitures = LoadFakeFurniture(categories);
            var users = LoadFakeUsers();
            LoadFakeRewiews(users, furnitures);
            LoadFakeOrders(users, furnitures);
        }

        private static IEnumerable<Category> LoadFakeCategories()
        {
            var faker = GetFaker<Category>()
                .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                .RuleFor(x => x.Name, f => f.Commerce.Department());

            return LoadDatasToDb(faker.Generate(CATEGORIES_COUNT));
        }

        private static IEnumerable<Furniture> LoadFakeFurniture(IEnumerable<Category> categories)
        {
            var faker = GetFaker<Furniture>()
                .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                .RuleFor(x => x.Description, f => f.Lorem.Paragraph())
                .RuleFor(x => x.Price, f => f.Random.Decimal(10, 1000))
                .RuleFor(x => x.CategoryId, f => f.PickRandom(categories).Id);

            return LoadDatasToDb(faker.Generate(FURNITURE_COUNT));
        }

        private static IEnumerable<User> LoadFakeUsers()
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

            LoadDatasToDb(new[]
            {
                new IdentityUserRole<int>() { UserId = 1, RoleId = 1 },
                new IdentityUserRole<int>() { UserId = 2, RoleId = 2 },
                new IdentityUserRole<int>() { UserId = 3, RoleId = 3 },
            });

            return LoadDatasToDb(new[]
            {
                user,
                moderator,
                admin,
            });
        }

        private static void LoadFakeRewiews(IEnumerable<User> users, IEnumerable<Furniture> furnitures)
        {
            var faker = GetFaker<Review>()
                .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                .RuleFor(x => x.Comment, f => f.Lorem.Paragraph())
                .RuleFor(x => x.Evaluation, f => f.Random.Int(1, 11))
                .RuleFor(x => x.DateTime, f => f.Date.Between(_defaultDateTime.AddMonths(-1), _defaultDateTime))
                .RuleFor(x => x.UserId, f => f.PickRandom(users).Id)
                .RuleFor(x => x.FurnitureId, f => f.PickRandom(furnitures).Id);

            LoadDatasToDb(faker.Generate(REVIEW_COUNT));
        }

        private static void LoadFakeOrders(IEnumerable<User> users, IEnumerable<Furniture> furnitures)
        {
            var faker = GetFaker<Order>()
                .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                .RuleFor(x => x.Count, f => f.Random.Int(1, 5))
                .RuleFor(x => x.DateOfOrder, f => f.Date.Between(_defaultDateTime.AddMonths(-1), _defaultDateTime)) // AddMonths(-1) - substract one month
                .RuleFor(x => x.UserId, f => f.PickRandom(users).Id)
                .RuleFor(x => x.FurnitureId, f => f.PickRandom(furnitures).Id);

            LoadDatasToDb(faker.Generate(ORDER_COUNT));
        }

        private static IEnumerable<TEntity> LoadDatasToDb<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class
        {
            _builder.Entity<TEntity>().HasData(entities);
            return entities;
        }

        public static Faker<TEntity> GetFaker<TEntity>()
            where TEntity : class, IBaseEntity
        {
            return new Faker<TEntity>(LOCALE)
                .UseSeed(SEED);
        }
    }
}
