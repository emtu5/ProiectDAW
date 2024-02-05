using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunnerApp.Data.DTOs;
using RunnerApp.Services.UserService;

namespace RunnerApp.Controllers
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

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetUsers());
        }

        [HttpGet("username")]
        public async Task<IActionResult> GetUserByUsername(string username)
        {
            return Ok(await _userService.GetUserByUsername(username));
        }

        [HttpDelete("username")]
        public async Task<IActionResult> DeleteUserByUsername(string username)
        {
            return Ok(await _userService.DeleteUserByUsername(username));
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserDTO userDto)
        {
            return Ok(await _userService.AddUser(userDto));
        }

        [HttpPut]
        public async Task<IActionResult> ChangeUserByUsername()
        {
            return Ok();
        }
    }
}
