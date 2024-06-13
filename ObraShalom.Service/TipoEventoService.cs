using ObraShalom.Data.Interfaces;
using ObraShalom.Data.Repositories;
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using ObraShalom.Service.Interfaces;


namespace ObraShalom.Service
{
    public class TipoEventoService(ITipoEventoRepository eventoRepository) : ITipoEventoService
    {
        private readonly ITipoEventoRepository _eventoRepository = eventoRepository;

        public async Task<IEnumerable<TipoEventoEntity>> ObtenerEvento()
        {
            var evento = await _eventoRepository.ObtenerEvento();
            return from g in evento
                   select new TipoEventoEntity(g.Id, g.Nombre);
        }

        public async Task CrearTipoEvento(TipoEventoEntity evento)
        {
            var ObtenerNombre = await _eventoRepository.ObtenerEvento(nombre: evento.Nombre?.Trim());

            if (ObtenerNombre != null)
                throw new Exception("El nombre del evento ya existe");

            var eventoEntity = new TipoEventoEntity(evento.Id, evento.Nombre);
            await _eventoRepository.CrearTipoEvento(eventoEntity);
        }

        public async Task ActualizarEvento(int id, TipoEventoEntity evento)
        {
            var ObtenerNombre = await _eventoRepository.ObtenerEvento(nombre: evento.Nombre?.Trim(), id);

            if (ObtenerNombre != null)
                throw new Exception("El nombre del evento ya existe");

            var eventoEntity = new TipoEventoEntity(id, evento.Nombre);
            await _eventoRepository.ActualizarEvento(eventoEntity);
        }
    }
}
