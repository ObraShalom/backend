using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class GrupoEntity(int id, string nombre, int numPersonas, TipoGrupoDto idTipoGrupo, int idObra, bool activo)
    {
        public int Id { get; set; } = id;
        public string? Nombre { get; set; } = nombre;
        public int NumPersonas { get; set; } = numPersonas;
        public TipoGrupoDto IdTipoGrupo { get; set; } = idTipoGrupo;
        public int IdObra { get; set; } = idObra;
        public bool Activo { get; set; } = activo;
        public string NombreTipo { set { ObtenerNombre(idTipoGrupo); } }
        public static string ObtenerNombre(TipoGrupoDto idTipo) => idTipo.ToString();
    }
}
