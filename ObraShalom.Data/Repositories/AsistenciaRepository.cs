using ObraShalom.Data.Interfaces;
using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Data.Repositories
{
    public class AsistenciaRepository(IDbConnection connection) : IAsistenciaRepository
    {
        public async Task<IEnumerable<AsistenciaDto>> ObtenerAsistencia(int idGrupo = default)
        {
                var sql = $"Select * from asistencia where idgrupo = {idGrupo} ";
                return await connection.QueryAsync<AsistenciaDto>(sql);
        }
    }
}
