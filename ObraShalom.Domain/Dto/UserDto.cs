using System.ComponentModel.DataAnnotations;

namespace ObraShalom.Domain.Dto
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public int IdRol { get; set; }
        public int IdObra { get; set; }
        public string Obra { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }

    }
}
