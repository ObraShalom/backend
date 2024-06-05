using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Data.Repositories
{
    public class EventoRepository(IDbConnection connection) : IEventoRepository
    {
        public async Task<IEnumerable<EventoDto>> ObtenerEvento(int idTipo, int idObra)
        {
            var sql = $"Select * from evento where idtipo = {idTipo} and idobra = {idObra} ";
            return await connection.QueryAsync<EventoDto>(sql);
        }
    }
}
