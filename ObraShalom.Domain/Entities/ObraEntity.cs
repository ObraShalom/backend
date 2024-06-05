using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class ObraEntity(int id, string nombre, bool activo)
    {
        public int Id { get; set; } = id;
        public string? Nombre { get; set; } = nombre;
        public bool Activo { get; set; } = activo;

    }
}
