﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }

    }
}
