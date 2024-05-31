using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using ObraShalom.Service.Interfaces;


namespace ObraShalom.Service
{
    public class ObraService(IObraRepository repository) : IObraService
    {
        private readonly IObraRepository _repository = repository;

        public async Task<IEnumerable<ObraEntity>> ObtenerObra() {

            var obra = await _repository.ObtenerObra();
            return from g in obra
                   select new ObraEntity(g.Id, nombre: g.Nombre);
        }
    }
}
