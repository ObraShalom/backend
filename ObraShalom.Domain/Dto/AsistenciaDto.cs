using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Dto
{
    public class AsistenciaDto
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int IdGrupo { get; set; }
        public int NumComprometidos { get; set; }
    }
}
