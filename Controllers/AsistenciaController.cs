using Microsoft.AspNetCore.Mvc;
using ObraShalom.Domain.Entities;
using ObraShalom.Service;
using ObraShalom.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            return await _asistenciaService.ObtenerAsistencia(1);
        }

        // GET api/<AsistenciaController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<AsistenciaEntity>> Get(int id)
        {
            return await _asistenciaService.ObtenerAsistencia(id);
        }

        // POST api/<AsistenciaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AsistenciaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AsistenciaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
