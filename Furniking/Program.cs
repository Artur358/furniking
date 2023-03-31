
using Furniking.DAL.Data;
using Furniking.DAL.Data.Helpers;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Implementations;
using Furniking.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Furniking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<DataContext>(op =>
            {
                op
                .UseLazyLoadingProxies()
                .UseSqlServer(builder.Configuration.GetConnectionString("devDB"));
            });

            var db = builder.Services.BuildServiceProvider().GetService<DataContext>();
            db.LoadFakeData();


            builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}