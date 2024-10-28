using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using OfficeBoySystem.Service.AdminUser.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeBoySystem.Data.Data;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;

namespace OfficeBoySystem.Service.AdminUser
{
    public class AdminUserService : IAdminUserService
    {
        private readonly ApplicationDbContext _context;

        public AdminUserService(ApplicationDbContext context)
        {
            _context = context;  // Corrected assignment
        }


        public async Task<string> LoginAsAdminAsync(AdminUserDto adminUserDto)
        {
            var adminType = await _context.UserTypes.FirstOrDefaultAsync(ut => ut.Type == "Admin");
            if (adminType == null)
            {
                return "Admin user type not found.";
            }

            var adminUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == adminUserDto.Email && u.UserTypeId == adminType.Id);

            if (adminUser == null)
            {
                return "Admin not found.";
            }

            if (!BCrypt.Net.BCrypt.Verify(adminUserDto.Password, adminUser.PasswordHash))
            {
                return "Invalid password.";
            }

            return "Login successful.";
        }
    }


}


