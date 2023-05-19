using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Mangement_System.Controllers
{
        [Route("api/admins")]
        [ApiController]
        public class AdminController : ControllerBase
        {
            private readonly IAdminService _adminService;

            public AdminController(IAdminService adminService)
            {
                _adminService = adminService;
            }

            [HttpPost("register")]
            public IActionResult RegisterAdmin(AdminRegistrationModel adminRegistrationModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var addedAdmin = _adminService.RegisterAdmin(adminRegistrationModel);
                return CreatedAtAction(nameof(GetAdmin), new { id = addedAdmin.Id }, addedAdmin);
            }

            [HttpPost("login")]
            public IActionResult LoginAdmin(AdminLoginModel adminLoginModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var admin = _adminService.LoginAdmin(adminLoginModel);
                if (admin == null)
                    return Unauthorized();

                return Ok(admin);
            }

            [HttpGet("{id}")]
            public IActionResult GetAdmin(int id)
            {
                var admin = _adminService.GetAdminById(id);
                if (admin == null)
                    return NotFound();

                return Ok(admin);
            }
        }
    

}
