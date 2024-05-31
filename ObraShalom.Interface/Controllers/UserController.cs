﻿using Microsoft.AspNetCore.Mvc;
using ObraShalom.Domain.Entities;
using ObraShalom.Domain.Models.Request;
using ObraShalom.Service;
using ObraShalom.Service.Interfaces;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) => _userService = userService;

        [HttpPost("Login")]
        public IActionResult AuthLogin(AuthRequest auth)
        {
            var resp = _userService.Auth(auth);
            return Ok(resp);
        }

        // POST api/<AsistenciaController>
        [HttpPost("Registro")]
        public async Task<IActionResult> Post([FromBody] UserEntity user)
        {
            await _userService.CrearUsuario(user, "");
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<UserEntity>> Get()
        {
            return await _userService.ListarUsuarios();
        }
    }
}
