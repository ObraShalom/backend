using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoEventoController(ITipoEventoService eventoService) : ControllerBase
    {
        private readonly ITipoEventoService _eventoService = eventoService;

        // GET: api/<TipoEventoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _eventoService.ObtenerEvento());
        }

        // GET api/<TipoEventoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoEventoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TipoEventoEntity tipoEvento)
        {
            await _eventoService.CrearTipoEvento(tipoEvento);
            return Ok();
        }

        // PUT api/<TipoEventoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TipoEventoEntity obra)
        {
            await _eventoService.ActualizarEvento(id, obra);
            return Ok();
        }

        // DELETE api/<TipoEventoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
