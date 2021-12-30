using Geekend.Model.Requests.User;
using Geekend.Model.Responses.User;
using Geekend.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Geekend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // Get all users
        [HttpGet("getAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _userService.GetAllUsers();
            return Ok(result);
        }

        // Get a user
        [HttpGet("getUserById")]
        public async Task<IActionResult> GetUserById(int getUserById)
        {
            var result = await _userService.GetUserById(getUserById);
            return Ok(result);
        }

        // Insert a user
        [HttpPost("insertUser")]
        public async Task<IActionResult> InsertUser([FromBody] InsertUserDto insertUserDto)
        {
            var result = await _userService.InsertUser(insertUserDto);
            return Ok(result);
        }

        // Update a user
        [HttpPut("updateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDto updateUserDto)
        {
            var result = await _userService.UpdateUser(updateUserDto);
            return Ok(result);
        }
    }
}
