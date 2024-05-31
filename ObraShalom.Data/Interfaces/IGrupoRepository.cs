using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Data.Interfaces
{
    public interface IGrupoRepository
    {
        Task<IEnumerable<GrupoDto>> ObtenerGrupo();
        Task<IEnumerable<GrupoDto>> ObtenerGrupo(int tipo, int obra);
    }
}
