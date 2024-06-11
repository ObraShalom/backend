using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class TipoEventoEntity(int id, string nombre)
    {
        public int Id { get; set; } = id;
        public string Nombre { get; set; } = nombre;
    }
}
