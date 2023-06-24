using Microsoft.AspNetCore.Mvc;
using Models.DataBaseModels;
using Services.Interface;

namespace Pizzaria.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(User user)
        {
            var userCreated = await _userService.CreateUserAsync(user);
            return Ok(userCreated);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return Ok(user);
        }

    }
}

