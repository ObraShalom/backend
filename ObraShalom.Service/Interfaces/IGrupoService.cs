using ObraShalom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Service.Interfaces
{
    public interface IGrupoService
    {
        Task<IEnumerable<GrupoEntity>> ObtenerGrupos();
        Task<IEnumerable<GrupoEntity>> ObtenerGrupos(int tipo, int obra);
        Task CrearGrupo(GrupoEntity obra);
        Task ActualizarGrupo(int id, GrupoEntity obra);
    }
}
