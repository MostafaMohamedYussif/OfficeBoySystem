using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Repository.AttendaceRepository;
using OfficeBoySystem.Repository.BuildingRepository;
using OfficeBoySystem.Repository.CityRepository;
using OfficeBoySystem.Repository.DrinkRepository;
using OfficeBoySystem.Repository.FloorRepository;
using OfficeBoySystem.Repository.LocationRepository;
using OfficeBoySystem.Repository.OrderDetailRepository;
using OfficeBoySystem.Repository.OrderRepository;
using OfficeBoySystem.Repository.OrderStatusRepository;
using OfficeBoySystem.Repository.ShiftRepository;
using OfficeBoySystem.Repository.UserRepository;
using OfficeBoySystem.Repository.UserTypeRepository;

namespace OfficeBoySystem.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
           



            var app = builder.Build();
             


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
