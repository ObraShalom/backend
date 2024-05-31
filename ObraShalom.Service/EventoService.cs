using ObraShalom.Data.Interfaces;
using ObraShalom.Data.Repositories;
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using ObraShalom.Service.Interfaces;


namespace ObraShalom.Service
{
    public class EventoService(IEventoRepository eventoRepository) : IEventoService
    {
        private readonly IEventoRepository _eventoRepository = eventoRepository;

        public async Task<IEnumerable<EventoEntity>> ObtenerEvento(int idTipo, int idObra)
        {
            var asistencia = await _eventoRepository.ObtenerEvento(idTipo, idObra);
            return from g in asistencia
                   select new EventoEntity(g.Id, g.Fecha, g.NumPersonas, g.idObra, g.Nombre, g.idTipo);
        }
    }
}
