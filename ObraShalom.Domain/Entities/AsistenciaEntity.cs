using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class AsistenciaEntity(int id, DateTime fecha, int idGrupo, int numComprometidos)
    {
        public int Id { get; set; } = id;
        public DateTime Fecha { get; set; } = fecha;
        public int IdGrupo { get; set; } = idGrupo;
        public int NumComprometidos { get; set; } = numComprometidos;
    }
}
