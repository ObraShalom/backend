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
    }
}
