using Microsoft.AspNetCore.Mvc;
using ObraShalom.Domain.Interfaces;
using ObraShalom.Domain.Models.Request;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        [HttpPost("Login")]
        public IActionResult AuthLogin(AuthRequest auth)
        {
            var resp = _userRepository.Auth(auth);
            return Ok(resp);
        }
    }
}
