using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Data.Interfaces
{
    public interface IAsistenciaRepository
    {
        Task<IEnumerable<AsistenciaDto>> ObtenerAsistencia(int? idGrupo = default);
        Task CrearAsistencia(AsistenciaEntity asistencia);
        Task ActualizarAsistencia(AsistenciaEntity asistencia);
        Task EliminarAsistencia(int id);
    }
}
