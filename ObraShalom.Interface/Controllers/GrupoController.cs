using Microsoft.AspNetCore.Mvc;
using ObraShalom.Domain.Entities;
using ObraShalom.Service.Interfaces;

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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GrupoOracionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GrupoOracionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
