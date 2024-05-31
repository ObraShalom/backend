using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Dto
{
    public class EventoDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int NumPersonas { get; set; }
        public string? Nombre { get; set; }
        public int idTipo { get; set; }
        public int idObra { get; set; }

    }
}
