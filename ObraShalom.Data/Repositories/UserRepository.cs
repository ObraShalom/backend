using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;

namespace ObraShalom.Data.Repositories
{
    public class UserRepository(IDbConnection connection, IOptions<AppSettings> settings) : IUserRepository
    {
        private readonly AppSettings _settings = settings.Value;

        public UserReponse Auth(AuthRequest auth)
        {
            
                UserReponse response = new();
                string spassword = Encrypt.GetSHA256(auth.Password);
                var sql = "Select * from usuario where Username = @Username and Password = @spassword";

                var usuario = connection.QuerySingle<UserDto>(sql, new { auth.Username, spassword });

                if (usuario == null) return null;

                response.Username = usuario.Username;
                response.Token = GetToken(usuario);

                return response;
        }

        private string GetToken(UserDto usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                        new(ClaimTypes.Name, usuario.Username.ToString()),
                    }),
                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public Task CrearUsuario(UserEntity usuario)
        {
                string spassword = Encrypt.GetSHA256(usuario.Password);
                var sql = $"insert into usuario (name, username, password, idrol, idobra) " +
                    $"values (@name, @username, @password, @idrol, @idobra)";

                return connection.ExecuteAsync(sql, new
                {
                    usuario.Name,
                    usuario.Username,
                    usuario.Password,
                    usuario.IdRol,
                    usuario.IdObra
                });
            
        }

        public Task<IEnumerable<UserDto>> ListarUsuario()
        {
                var sql = @$"select u.*, o.nombre as obra, r.nombre as rol
                         from usuario u 
                         inner join rol r on r.id = u.idrol 
                         inner join obra o on o.id = u.idobra ";
                return  connection.QueryAsync<UserDto>(sql);
        }
    }
}
