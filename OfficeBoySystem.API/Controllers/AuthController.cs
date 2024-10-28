using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeBoySystem.Service.AdminUser;
using OfficeBoySystem.Service.AdminUser.Dto;
using System.Threading.Tasks; 

namespace OfficeBoySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAdminUserService _adminUserService;

        public AuthController(IAdminUserService adminUserService)
        {
            _adminUserService = adminUserService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsAdmin([FromBody] AdminUserDto adminUserDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Call the service method to validate admin login
            var result = await _adminUserService.LoginAsAdminAsync(adminUserDto);

            if (result == "Login successful.")  // If the login was successful
            {
                return Ok("Login successful.");
            }
            else
            {
                return Unauthorized(result);  // If failed, return the message from service
            }
        }
    }
}
