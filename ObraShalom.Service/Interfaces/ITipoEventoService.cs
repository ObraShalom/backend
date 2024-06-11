using ObraShalom.Domain.Entities;

namespace ObraShalom.Service.Interfaces
{
    public interface ITipoEventoService
    {
        Task<IEnumerable<TipoEventoEntity>> ObtenerEvento();
        Task CrearTipoEvento(TipoEventoEntity evento);
        Task ActualizarEvento(int id, TipoEventoEntity evento);
    }
}
