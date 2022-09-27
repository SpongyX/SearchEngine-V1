using Microsoft.AspNetCore.Mvc;
using SearchEngine.Interfaces;
using SearchEngine.Models;

namespace SearchEngine.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("Login")]

        public IActionResult Login([FromBody] UserModel model)
        {
            var response = _userService.canLogin(model);
            return Ok(response);
        }
    }
}
