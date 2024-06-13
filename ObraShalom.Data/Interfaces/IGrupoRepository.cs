using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
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
        Task<IEnumerable<GrupoDto>> ObtenerGrupo(int? obra = default, int? tipo = default);
        Task CrearGrupo(GrupoEntity grupo);
        Task<GrupoDto> ObtenerGrupo(string nombre, int? id = default);
        Task ActualizarGrupo(GrupoEntity grupo);
    }
}
