// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using Google.Protobuf.WellKnownTypes;

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsistenciaController(IAsistenciaService asistenciaService) : ControllerBase
    {
        private readonly IAsistenciaService _asistenciaService = asistenciaService;

        // GET: api/<AsistenciaController>
        [HttpGet]
        public async Task<IEnumerable<AsistenciaEntity>> Get()
        {
            return await _asistenciaService.ObtenerAsistencia();
        }

        // GET api/<AsistenciaController>/5
        [HttpGet("{idGrupo}")]
        public async Task<IEnumerable<AsistenciaEntity>> Get(int idGrupo)
        {
            return await _asistenciaService.ObtenerAsistencia(idGrupo);
        }

        // POST api/<AsistenciaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AsistenciaEntity value)
        {
            await _asistenciaService.CrearAsistencia(value);
            return Ok();
        }

        // PUT api/<AsistenciaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] AsistenciaEntity value)
        {
            await _asistenciaService.ActualizarAsistencia(id, value);
            return Ok();
        }

        // DELETE api/<AsistenciaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _asistenciaService.EliminarAsistencia(id);
            return Ok();
        }
    }
}
