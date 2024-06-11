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
    public class TipoEventoRepository(IDbConnection connection) : ITipoEventoRepository
    {
        public async Task<IEnumerable<TipoEventoDto>> ObtenerEvento()
        {
            var sql = $"Select * from tipoevento ";
            return await connection.QueryAsync<TipoEventoDto>(sql);
        }

        public async Task CrearTipoEvento(TipoEventoEntity evento)
        {
            var sql = $"insert into tipoevento (nombre) " +
                $"values (@nombre)";

            await connection.ExecuteAsync(sql, new
            {
                evento.Nombre
            });
        }

        public async Task<TipoEventoDto> ObtenerEvento(string nombre, int? id)
        {
            var idValidation = id != null ? " and id <> @id " : "";

            var sql = @$"Select * 
                      from tipoevento 
                      where nombre = @nombre
                      {idValidation}";
            TipoEventoDto? tipoEventoDto = await connection.QueryFirstOrDefaultAsync<TipoEventoDto>(sql, new { Nombre = nombre, Id = id });
          
            return tipoEventoDto;
        }

        public async Task ActualizarEvento(TipoEventoEntity evento)
        {
            var sql = $"update tipoevento set nombre = @nombre where id = @id";
            await connection.ExecuteAsync(sql, new
            {
                evento.Id,
                evento.Nombre,
            });
        }
    }
}
