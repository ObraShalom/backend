using ObraShalom.Domain.Entities;

namespace ObraShalom.Service.Interfaces
{
    public interface IObraService
    {
        Task<IEnumerable<ObraEntity>> ObtenerObra();
        Task<ObraEntity> ObtenerObra(int id, bool? activo = true);
        Task CrearObra(ObraEntity obra);
        Task ActualizarObra(int id, ObraEntity obra);
    }
}