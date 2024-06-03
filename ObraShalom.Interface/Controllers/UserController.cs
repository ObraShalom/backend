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

        // POST api/<AsistenciaController>
        [HttpPost("Registro")]
        public async Task<IActionResult> Post([FromBody] UserEntity user)
        {
            await _userService.CrearUsuario(user, "");
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<UserEntity>> Get()
        {
            return await _userService.ListarUsuarios();
        }
    }
}
