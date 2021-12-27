using Geekend.Model.Requests.User;
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

        [HttpPost("insertUser")]
        public async Task<IActionResult> InsertUser([FromBody] InsertUserDto insertUserDto)
        {
            var result = await _userService.InsertUser(insertUserDto);
            return Ok(result);
        }
    }
}
