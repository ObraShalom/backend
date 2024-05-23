using backend.Data;
using backend.Interfaces;
using backend.Models.Common;
using backend.Models.Request;
using backend.Models.Response;
using backend.Tools;
using Dapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace backend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _connection;
        private readonly AppSettings _settings;

        public UserRepository(IDbConnection connection, IOptions<AppSettings> settings)
        {
            this._connection = connection;
            this._settings = settings.Value;
        }
        public UserReponse Auth(AuthRequest auth )
        {

            try
            {
                UserReponse response = new();
                string spassword = Encrypt.GetSHA256(auth.Password);
                var sql = "Select * from users where Username = @Username and Password = @spassword";

                var usuario = _connection.QuerySingle<User>(sql, new { auth.Username, spassword });

                if (usuario == null) return null;

                response.Username = usuario.Username;
                response.Token = GetToken(usuario);

                return response;

            }
            catch (Exception ex)
            {

                throw;
            }
            


               
        }

        private string GetToken(User usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Username.ToString()),

                }),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
