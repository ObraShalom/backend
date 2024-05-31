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

        public async Task<IEnumerable<AsistenciaEntity>> ObtenerAsistencia(int idGrupo)
        {
            var asistencia = await _asistenciaRepository.ObtenerAsistencia(idGrupo);
            return from g in asistencia
                   select new AsistenciaEntity(g.Id, g.Mes, g.IdGrupo, g.NumComprometidos);
        }

    }
}
