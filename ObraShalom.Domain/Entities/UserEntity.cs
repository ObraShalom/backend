﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Domain.Entities
{
    public class UserEntity(int id, string name, string username, string password, int idRol, int idObra, bool activo, string? token = default)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Username { get; set; } = username;
        public string Password { get; set; } = password;
        public int IdRol { get; set; } = idRol;
        public int IdObra { get; set; } = idObra;
        public string? Token { get; set; } = token;
        public string? Obra { get; set; }
        public string? Rol { get; set; }
        public bool Activo { get; set; } = activo;
        public static string ObtenerObra(string obra) => obra;
        public static string ObtenerRol(string rol) => rol;
    }

    
}
