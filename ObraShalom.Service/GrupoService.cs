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
                   select new GrupoEntity(g.Id, g.Nombre, g.NumPersonas, (TipoGrupoDto)g.IdTipoGrupo, g.IdObra, g.Activo);
        }

        public async Task<IEnumerable<GrupoEntity>> ObtenerGrupos(int tipo, int obra)
        {
            var grupos = await _grupoRepository.ObtenerGrupo(tipo, obra);
            return from g in grupos
                   select new GrupoEntity(g.Id, g.Nombre, g.NumPersonas, (TipoGrupoDto)g.IdTipoGrupo, g.IdObra, g.Activo);
        }
        public async Task CrearGrupo(GrupoEntity obra)
        {
            var ObtenerNombre = await _grupoRepository.ObtenerGrupo(nombre: obra.Nombre?.Trim());

            if (ObtenerNombre != null)
                throw new Exception("El nombre del grupo ya existe");

            var grupoEntity = new GrupoEntity(obra.Id, obra.Nombre, obra.NumPersonas, obra.IdTipoGrupo, obra.IdObra, obra.Activo);
            await _grupoRepository.CrearGrupo(grupoEntity);
        }
        public async Task ActualizarGrupo(int id, GrupoEntity obra)
        {
            var ObtenerNombre = await _grupoRepository.ObtenerGrupo(nombre: obra.Nombre?.Trim(), id);

            if (ObtenerNombre != null)
                throw new Exception("El nombre del grupo ya existe");

            var obraEntity = new GrupoEntity(id, obra.Nombre, obra.NumPersonas, obra.IdTipoGrupo, obra.IdObra, obra.Activo);
            await _grupoRepository.ActualizarGrupo(obraEntity);
        }
    }
}
