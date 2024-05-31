using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Data.Interfaces
{
    public interface IEventoRepository
    {
        Task<IEnumerable<EventoDto>> ObtenerEvento(int idTipo, int idObra);
    }
}
