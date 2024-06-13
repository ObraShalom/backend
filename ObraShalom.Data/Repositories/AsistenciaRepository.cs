using Microsoft.AspNetCore.Identity;
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
    public class AsistenciaRepository(IDbConnection connection) : IAsistenciaRepository
    {
        public async Task<IEnumerable<AsistenciaDto>> ObtenerAsistencia(int? idGrupo = default)
        {
            var idValidation = idGrupo != null ? " and idgrupo = @idgrupo " : "";

            var sql = @$"Select * from asistencia where id <> 0 
                        {idValidation} ";
            return await connection.QueryAsync<AsistenciaDto>(sql, new { IdGrupo = idGrupo });
        }
        public async Task CrearAsistencia(AsistenciaEntity asistencia)
        {
            var sql = $"insert into asistencia (fecha, numcomprometidos, idgrupo) " +
                $"values (@fecha, @numcomprometidos, @idgrupo)";

            await connection.ExecuteAsync(sql, new
            {
                asistencia.Fecha,
                asistencia.NumComprometidos,
                asistencia.IdGrupo
            });
        }
        public async Task ActualizarAsistencia(AsistenciaEntity asistencia)
        {

            var sql = $"update asistencia set fecha = @fecha, numcomprometidos = @numcomprometidos, idgrupo = @idgrupo where id = @id";

            await connection.ExecuteAsync(sql, new
            {
                asistencia.Id,
                asistencia.Fecha,
                asistencia.NumComprometidos,
                asistencia.IdGrupo
            });
        }

        public async Task EliminarAsistencia(int id)
        {
            var sql = $"delete from asistencia where id = @id";

            await connection.ExecuteAsync(sql, new
            {
                Id = id
            });
        }


    }
}
