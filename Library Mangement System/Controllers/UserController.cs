using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Mangement_System.Controllers
{
        [Route("api/users")]
        [ApiController]
        public class UserController : ControllerBase
        {
            private readonly IUserService _userService;

            public UserController(IUserService userService)
            {
                _userService = userService;
            }

            [HttpPost("register")]
            public IActionResult RegisterUser(UserRegistrationModel userRegistrationModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var addedUser = _userService.RegisterUser(userRegistrationModel);
                return CreatedAtAction(nameof(GetUser), new { id = addedUser.Id }, addedUser);
            }

            [HttpPost("login")]
            public IActionResult LoginUser(UserLoginModel userLoginModel)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = _userService.LoginUser(userLoginModel);
                if (user == null)
                    return Unauthorized();

                return Ok(user);
            }

            [HttpGet("{id}")]
            public IActionResult GetUser(int id)
            {
                var user = _userService.GetUserById(id);
                if (user == null)
                    return NotFound();

                return Ok(user);
            }
        }
    

}
