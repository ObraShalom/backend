// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObraController(IObraService obraService) : ControllerBase
    {
        private readonly IObraService _obraService = obraService;

        // GET: api/<ObraController>
        [ProducesResponseType(typeof(IEnumerable<ObraEntity>), 200)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _obraService.ObtenerObra());
        }

        // GET api/<ObraController>/5
        [ProducesResponseType(typeof(ObraEntity), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 404)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, bool? activo = false)
        {
            return Ok(await _obraService.ObtenerObra(id, activo));
        }

        // POST api/<ObraController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ObraEntity value)
        {
            await _obraService.CrearObra(value);
            return Ok();
        }

        // PUT api/<ObraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ObraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
