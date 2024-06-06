using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Entities;

namespace ObraShalom.Data.Repositories
{
    public class ObraRepository(IDbConnection connection) : IObraRepository
    {

        public async Task<IEnumerable<ObraDto>> ObtenerObra()
        {

            var sql = $"Select * from obra ";
            return await connection.QueryAsync<ObraDto>(sql);

        }

        public async Task<ObraDto> ObtenerObra(int id, bool? active)
        {

            var sql = $"Select * from obra where id = {id} and activo = {active}";
            return await connection.QueryFirstAsync<ObraDto>(sql);

        }

        public async Task CrearObra(ObraEntity obra)
        {
            var sql = $"insert into obra (nombre, activo) " +
                $"values (@nombre, @activo)";

            await connection.ExecuteAsync(sql, new
            {
                obra.Nombre,
                obra.Activo
            });
        }

        public async Task<ObraDto> ObtenerObra(string nombre, int? id)
        {
            var sql = @$"Select * 
                      from obra 
                      where id = @nombre 
                      and activo = @activo";
            ObraDto? obraDto = await connection.QueryFirstOrDefaultAsync<ObraDto>(sql, new { Nombre = nombre, Activo = true });
            return obraDto;
        }

        public async Task ActualizarObra(ObraEntity obra)
        {
            var sql = $"update obra set nombre = @nombre, activo = @activo where id = @id";

            await connection.ExecuteAsync(sql, new
            {
                obra.Id,
                obra.Nombre,
                obra.Activo
            });
        }

        public Task<ObraDto> ObtenerObra(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
