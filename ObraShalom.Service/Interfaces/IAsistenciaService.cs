using ObraShalom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Service.Interfaces
{
    public interface IAsistenciaService
    {
        Task<IEnumerable<AsistenciaEntity>> ObtenerAsistencia(int? idGrupo = default);
        Task EliminarAsistencia(int id);
        Task CrearAsistencia(AsistenciaEntity asistencia);
        Task ActualizarAsistencia(int id, AsistenciaEntity asistencia);
    }
}
