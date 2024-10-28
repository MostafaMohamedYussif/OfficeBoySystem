
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using OfficeBoySystem.Data.Interface;
using OfficeBoySystem.Repository;
using OfficeBoySystem.Service.AdminUser;
namespace OfficeBoySystem.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Configure the DbContext to use PostgreSQL
            builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IScoppedRepository, BaseRepository>();
            builder.Services.AddScoped<IAdminUserService, AdminUserService>();


            builder.Services.AddScoped <UserManager<User>>();
            builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dataContext = services.GetRequiredService<ApplicationDbContext>();
                var userManager = services.GetRequiredService<UserManager<User>>();

                // Apply any pending migrations
                await dataContext.Database.MigrateAsync();

                // Call the seeding method with the userManager
                await dataContext.SeedDatabaseAsync(userManager);
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            await app.RunAsync();
        }
    }
}
