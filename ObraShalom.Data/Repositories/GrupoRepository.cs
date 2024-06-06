
using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Dto;

namespace ObraShalom.Data.Repositories
{
    public class GrupoRepository(IDbConnection connection) : IGrupoRepository
    {
        public async Task<IEnumerable<GrupoDto>> ObtenerGrupo()
        {
            var sql = $"Select * from grupo where activo = true ";
            return await connection.QueryAsync<GrupoDto>(sql);
        }
        public async Task<IEnumerable<GrupoDto>> ObtenerGrupo(int tipo, int obra)
        {
            var sql = $"Select * from grupo where idobra = {obra} and idtipogrupo = {obra}";
            return await connection.QueryAsync<GrupoDto>(sql);
        }
    }
}
