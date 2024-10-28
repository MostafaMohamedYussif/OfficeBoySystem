using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OfficeBoySystem.Data.Entities;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {

        private readonly IConfiguration _configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

     
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
        }
        public async Task SeedDatabaseAsync(UserManager<User> userManager)
        {
            var adminIdString = _configuration["AdminSettings:AdminId"];
            if (!int.TryParse(adminIdString, out int adminId))
            {
                throw new InvalidOperationException("Invalid AdminId configuration.");
            }

            // Check if any UserTypes already exist
            if (!await UserTypes.AnyAsync())
            {
                // Add UserTypes using the correct class name (UserType)
                await UserTypes.AddRangeAsync(
                    new UserType { Type = "Admin" },     
                    new UserType { Type = "Employee" },  
                    new UserType { Type = "Office Boy" } 
                );
            }

            var adminType = await UserTypes.FirstOrDefaultAsync(ut => ut.Type == "Admin");
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword("adminuser@123");

            if (adminType != null)
            {
                if (!await Users.AnyAsync(u => u.Email == "admin@gmail.com"))
                {
                    await Users.AddAsync(new User
                    {
                        Id = adminId.ToString(),
                        FirstNameAr = "المدير",
                        LastNameAr = "المسؤول",
                        FirstNameEn = "Admin",
                        LastNameEn = "User",
                        Email = "adminuser@gmail.com",
                        PasswordHash = hashedPassword,
                        PhoneNumber = "1234567890",
                        UserTypeId = adminType.Id
                    });
                }
            }

            await SaveChangesAsync();
        }




        #region 
        //public async Task SeedAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        //{
        //    // Admin credentials
        //    var adminEmail = "admin@gmail.com";
        //    var adminPassword = "Admin*123";

        //    // Ensure Admin role exists
        //    if (!await roleManager.RoleExistsAsync("Admin"))
        //    {
        //        await roleManager.CreateAsync(new IdentityRole("Admin"));
        //    }

        //    // Check if the admin user already exists if its not then create it 
        //    if (!await userManager.Users.AnyAsync(u => u.Email == adminEmail))
        //    {
        //        var adminUser = new User
        //        {
        //            UserName = adminEmail,
        //            Email = adminEmail,
        //            EmailConfirmed = true 
        //        };

        //        var result = await userManager.CreateAsync(adminUser, adminPassword);
        //        if (result.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(adminUser, "Admin");
        //        }
        //        else
        //        {

        //            foreach (var error in result.Errors)
        //            {
        //                Console.WriteLine(error.Description);
        //            }
        //        }
        //    }
        //} 
        #endregion

    }
}
