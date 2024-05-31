using ObraShalom.Domain.Dto;

namespace ObraShalom.Data.Repositories
{
    public class UserRepository(IDbConnection connection, IOptions<AppSettings> settings) : IUserRepository
    {
        private readonly AppSettings _settings = settings.Value;

        public UserReponse Auth(AuthRequest auth)
        {
            try
            {
                UserReponse response = new();
                string spassword = Encrypt.GetSHA256(auth.Password);
                var sql = "Select * from users where Username = @Username and Password = @spassword";

                var usuario = connection.QuerySingle<User>(sql, new { auth.Username, spassword });

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
                Subject = new ClaimsIdentity(
                [
                    new(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new(ClaimTypes.Name, usuario.Username.ToString()),
                ]),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
