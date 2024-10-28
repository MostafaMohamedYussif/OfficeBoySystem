using OfficeBoySystem.Service.AdminUser.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Service.AdminUser
{
    public interface IAdminUserService
    {
        public Task<string> LoginAsAdminAsync(AdminUserDto adminUserDto);
    }

}
