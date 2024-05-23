using Microsoft.AspNetCore.Mvc;
using ObraShalom.Domain.Entities;
using ObraShalom.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoService _grupoService;
        public GrupoController(IGrupoService grupoService) => _grupoService = grupoService;

        // GET: api/<GrupoOracionController>
        [HttpGet]
        public async Task<IEnumerable<GrupoEntity>> Get()
        {
            return await _grupoService.ObtenerGrupos();
        }

        // GET api/<GrupoOracionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
