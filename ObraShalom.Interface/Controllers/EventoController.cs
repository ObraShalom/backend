// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController(IEventoService eventoService) : ControllerBase
    {
        private readonly IEventoService _eventoService = eventoService;

        // GET: api/<EventoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EventoController>/5
        [HttpGet("{idObra}")]
        public async Task<IActionResult> Get(int idObra, int idTipo)
        {
            return Ok(await _eventoService.ObtenerEvento(idObra, idTipo));
        }

        // POST api/<EventoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EventoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
