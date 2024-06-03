using Microsoft.AspNetCore.Mvc;
using ObraShalom.Domain.Models.Request;
using ObraShalom.Service.Interfaces;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService;

        [HttpPost("Login")]
        public IActionResult AuthLogin(AuthRequest auth)
        {
            var resp = _userService.Auth(auth);
            return Ok(resp);
        }
    }
}
