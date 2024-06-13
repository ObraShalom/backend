using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Data.Interfaces
{
    public interface ITipoEventoRepository
    {
        Task<IEnumerable<TipoEventoDto>> ObtenerEvento();
        Task CrearTipoEvento(TipoEventoEntity evento);
        Task<TipoEventoDto> ObtenerEvento(string nombre, int? id = default);
        Task ActualizarEvento(TipoEventoEntity evento);
    }
}
