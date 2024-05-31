using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using ObraShalom.Service.Interfaces;


namespace ObraShalom.Service
{
    public class GrupoService(IGrupoRepository grupoRepository) : IGrupoService
    {
        private readonly IGrupoRepository _grupoRepository = grupoRepository;

        public async Task<IEnumerable<GrupoEntity>> ObtenerGrupos() {

            var grupos = await _grupoRepository.ObtenerGrupo();
            return from g in grupos
                   select new GrupoEntity(g.Id, g.Nombre, g.NumPersonas, (TipoGrupoDto)g.IdTipoGrupo, g.IdObra);
        }

        public async Task<IEnumerable<GrupoEntity>> ObtenerGrupos(int tipo, int obra)
        {
            var grupos = await _grupoRepository.ObtenerGrupo(tipo, obra);
            return from g in grupos
                   select new GrupoEntity(g.Id, g.Nombre, g.NumPersonas, (TipoGrupoDto)g.IdTipoGrupo, g.IdObra);
        }
    }
}
