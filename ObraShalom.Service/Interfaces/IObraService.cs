using ObraShalom.Domain.Entities;

namespace ObraShalom.Service.Interfaces
{
    public interface IObraService
    {
        Task<IEnumerable<ObraEntity>> ObtenerObra();
    }
}