using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class AsistenciaEntity(int id, int mes, int idGrupo, int numComprometidos)
    {
        public int Id { get; set; } = id;
        public int Mes { get; set; } = mes;
        public int IdGrupo { get; set; } = idGrupo;
        public int NumComprometidos { get; set; } = numComprometidos;
    }
}
