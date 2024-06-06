using ObraShalom.Data.Interfaces;
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
                   select new ObraEntity(g.Id, nombre: g.Nombre, g.Activo);
        }

        public async Task<ObraEntity> ObtenerObra(int id, bool? activo = true)
        {
            var obra = await _repository.ObtenerObra(id, activo);
            return new ObraEntity(obra.Id, nombre: obra.Nombre, obra.Activo);
        }

        public async Task CrearObra(ObraEntity obra)
        {
            var obraEntity = new ObraEntity(obra.Id, obra.Nombre, obra.Activo);
            var ObtenerNombre = await _repository.ObtenerObra(nombre: obra.Nombre?.Trim());

            if (ObtenerNombre != null)
                throw new Exception("El nombre de la obra ya existe");

            await _repository.CrearObra(obraEntity);
        }

        public async Task ActualizarObra(int id, ObraEntity obra)
        {
            var obraEntity = new ObraEntity(id, obra.Nombre, obra.Activo);
            await _repository.ActualizarObra(obraEntity);
        }
    }
}
