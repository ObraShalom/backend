using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var ObtenerNombre = await ObtenerObra(nombre: obra.Nombre?.Trim());

            if (obra != null)
                throw new Exception("El nombre de la obra ya existe");

            var sql = $"insert into obra (nombre, activo) " +
                $"values (@nombre, @activo)";

            await connection.ExecuteAsync(sql, new
            {
                obra.Nombre,
                obra.Activo
            });
        }

        public async Task<ObraDto> ObtenerObra(string nombre)
        {
            var sql = $"Select * from obra where id = @nombre and activo = @activo";
            ObraDto? obraDto = await connection.QueryFirstOrDefaultAsync<ObraDto>(sql, new { Nombre = nombre, Activo = true });
            return obraDto;
        }
    }
}
