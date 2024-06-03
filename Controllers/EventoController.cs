using Microsoft.AspNetCore.Mvc;
using ObraShalom.Domain.Entities;
using ObraShalom.Service;
using ObraShalom.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController(IEventoService eventoService) : ControllerBase
    {
        private const string V = "{idObra}";
        private readonly IEventoService _eventoService = eventoService;

        // GET: api/<EventoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EventoController>/5
        [HttpGet(V)]
        public async Task<IEnumerable<EventoEntity>> Get(int idObra, int idTipo)
        {
            return await _eventoService.ObtenerEvento(idObra, idTipo);
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
