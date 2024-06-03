using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class UserEntity(int id, string name, string username, string password, int idRol, int idObra, string? token = default)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Username { get; set; } = username;
        public string Password { get; set; } = password;
        public int IdRol { get; set; } = idRol;
        public int IdObra { get; set; } = idObra;
        public string Tokcen { get; set; } = token;
    }
}
