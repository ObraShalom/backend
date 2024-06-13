
using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;

namespace ObraShalom.Data.Repositories
{
    public class GrupoRepository(IDbConnection connection) : IGrupoRepository
    {
        public async Task<IEnumerable<GrupoDto>> ObtenerGrupo()
        {
            var sql = $"Select * from grupo where activo = true ";
            return await connection.QueryAsync<GrupoDto>(sql);
        }
        public async Task<IEnumerable<GrupoDto>> ObtenerGrupo(int? obra = default, int? tipo = default)
        {
            var sql = $"Select * from grupo where idobra = {obra} and idtipogrupo = {tipo}";
            return await connection.QueryAsync<GrupoDto>(sql);
        }
        public async Task CrearGrupo(GrupoEntity grupo)
        {
            var sql = $"insert into grupo (nombre, numpersonas, idobra, idtipogrupo, activo) " +
                $"values (@nombre, @numpersonas, @idobra, @idtipogrupo, @activo)";

            await connection.ExecuteAsync(sql, new
            {
                grupo.Nombre,
                grupo.NumPersonas,
                grupo.IdObra,
                grupo.IdTipoGrupo, 
                grupo.Activo
            });
        }
        public async Task<GrupoDto> ObtenerGrupo(string nombre, int? id)
        {
            var idValidation = id != null ? " and id <> @id " : "";

            var sql = @$"Select * 
                      from grupo 
                      where nombre = @nombre 
                      and activo = @activo 
                      {idValidation}";
            GrupoDto? grupoDto = await connection.QueryFirstOrDefaultAsync<GrupoDto>(sql, new { Nombre = nombre, Activo = true, Id = id });
            return grupoDto;
        }

        public async Task ActualizarGrupo(GrupoEntity grupo)
        {

            var sql = $"update grupo set nombre = @nombre, numpersonas = @numpersonas, idtipogrupo = @idtipogrupo, activo = @activo where id = @id";

            await connection.ExecuteAsync(sql, new
            {
                grupo.Id,
                grupo.Nombre,
                grupo.NumPersonas,
                grupo.IdTipoGrupo,
                grupo.Activo
            });
        }
    }
}
