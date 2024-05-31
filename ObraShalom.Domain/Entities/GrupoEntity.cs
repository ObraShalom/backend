using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class GrupoEntity(int id, string nombre, int numeroPersonas, TipoGrupoDto tipoGrupo, int idObra)
    {
        public int Id { get; set; } = id;
        public string? Nombre { get; set; } = nombre;
        public int NumeroPersonas { get; set; } = numeroPersonas;
        public TipoGrupoDto IdTipo { get; set; } = tipoGrupo;
        public int IdObra { get; set; } = idObra;
        public string NombreTipo { set { ObtenerNombre(tipoGrupo); } }

        public static string ObtenerNombre(TipoGrupoDto idTipo) => idTipo.ToString();
    }
}
