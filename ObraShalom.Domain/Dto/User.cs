using System.ComponentModel.DataAnnotations;

namespace ObraShalom.Domain.Dto
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public int IdRol { get; set; }

    }
}
