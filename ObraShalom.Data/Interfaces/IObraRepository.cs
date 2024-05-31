using ObraShalom.Domain.Entities;

namespace ObraShalom.Data.Interfaces
{
    public interface IObraRepository
    {
        Task<IEnumerable<ObraDto>> ObtenerObra();
    }
}
