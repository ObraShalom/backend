using ObraShalom.Data.Interfaces;
using ObraShalom.Data.Repositories;
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using ObraShalom.Service.Interfaces;


namespace ObraShalom.Service
{
    public class AsistenciaService(IAsistenciaRepository asistenciaRepository) : IAsistenciaService
    {
        private readonly IAsistenciaRepository _asistenciaRepository = asistenciaRepository;

        public async Task<IEnumerable<AsistenciaEntity>> ObtenerAsistencia(int? idGrupo = default)
        {
            var asistencia = await _asistenciaRepository.ObtenerAsistencia(idGrupo);
            return from g in asistencia
                   select new AsistenciaEntity(g.Id, g.Fecha, g.IdGrupo, g.NumComprometidos);
        }
        public async Task CrearAsistencia(AsistenciaEntity asistencia)
        {
            var asistenciaEntity = new AsistenciaEntity(asistencia.Id, asistencia.Fecha, asistencia.IdGrupo, asistencia.NumComprometidos);
            await _asistenciaRepository.CrearAsistencia(asistenciaEntity);
        }

        public async Task ActualizarAsistencia(int id, AsistenciaEntity asistencia)
        {
            var asistenciaEntity = new AsistenciaEntity(id, asistencia.Fecha, asistencia.IdGrupo, asistencia.NumComprometidos);
            await _asistenciaRepository.ActualizarAsistencia(asistenciaEntity);
        }

        public async Task EliminarAsistencia(int id)
        {
            await _asistenciaRepository.EliminarAsistencia(id);
        }
    }
}
