// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController(IGrupoService grupoService) : ControllerBase
    {
        private readonly IGrupoService _grupoService = grupoService;

        // GET: api/<GrupoOracionController>
        [HttpGet]
        public async Task<IEnumerable<GrupoEntity>> Get()
        {
            return await _grupoService.ObtenerGrupos();
        }

        // GET api/<GrupoOracionController>/5
        [HttpGet("{tipo}")]
        public async Task<IEnumerable<GrupoEntity>> Get(int tipo, int obra)
        {
            return await _grupoService.ObtenerGrupos(tipo, obra);
        }

        // POST api/<GrupoOracionController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GrupoEntity value)
        {
            await _grupoService.CrearGrupo(value);
            return Ok();
        }

        // PUT api/<GrupoOracionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] GrupoEntity obra)
        {
            await _grupoService.ActualizarGrupo(id, obra);
            return Ok();
        }

        // DELETE api/<GrupoOracionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
