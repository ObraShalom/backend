using ObraShalom.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class EventoEntity(int id, DateTime fecha, int numPersonas, int idObra, string nombre, int idTipo)
    {
        public int Id { get; set; } = id;
        public DateTime Fecha { get; set; } = fecha;
        public int NumPersonas { get; set; } = numPersonas;
        public int IdObra { get; set; } = idObra;
        public string Nombre { get; set; } = nombre;
        public int idTipo { get; set; } = idTipo;
    }
}
