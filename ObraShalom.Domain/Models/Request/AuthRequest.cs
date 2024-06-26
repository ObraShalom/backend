﻿using System.ComponentModel.DataAnnotations;

namespace ObraShalom.Domain.Models.Request
{
    public class AuthRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
