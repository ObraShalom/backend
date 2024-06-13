using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Dto
{
    public class GrupoDto
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public int NumPersonas { get; set; }
        public int IdTipoGrupo { get; set; }
        public int IdObra { get; set; }
        public bool Activo { get; set; }

    }
}
