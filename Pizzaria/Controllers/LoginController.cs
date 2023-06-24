using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using Services.Interface;

namespace Pizzaria.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync(LoginModel loginModel)
        {
            var user = await _userService.GetUserByEmailAsync(loginModel.Email);

            if (user == null)
            {
                return NotFound();
            }
            Console.WriteLine("USER");
            Console.WriteLine(user.Password);
            Console.WriteLine("Model");

            Console.WriteLine(loginModel.Password);
            if (!user.Password.Equals(loginModel.Password))
            {
                return Forbid();
            }
            var token = TokenService.GenerateToken(user);
            user.Password = String.Empty;
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
