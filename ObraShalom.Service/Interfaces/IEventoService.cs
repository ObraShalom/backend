using ObraShalom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Service.Interfaces
{
    public interface IEventoService
    {
        Task<IEnumerable<EventoEntity>> ObtenerEvento(int idTipo, int idObra);
    }
}
