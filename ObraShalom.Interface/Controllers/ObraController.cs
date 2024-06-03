// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObraShalom.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObraController(IObraService obraService) : ControllerBase
    {
        private readonly IObraService _obraService = obraService;

        // GET: api/<ObraController>

        [HttpGet]
        public async Task<IEnumerable<ObraEntity>> Get()
        {
            return await _obraService.ObtenerObra();
        }

        // GET api/<ObraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ObraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
