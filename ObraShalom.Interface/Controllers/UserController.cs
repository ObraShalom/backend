using ObraShalom.Domain.Models.Request;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost("Login")]
        public IActionResult AuthLogin(AuthRequest auth)
        {
            var resp = _userService.Auth(auth);
            return Ok(resp);
        }
    }
}
