using ObraShalom.Domain.Entities;
using ObraShalom.Domain.Interfaces;
using ObraShalom.Domain.Models.Request;
using ObraShalom.Domain.Models.Response;
using ObraShalom.Service.Interfaces;

namespace ObraShalom.Service
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;

        public UserReponse Auth(AuthRequest auth)
        {
            return _userRepository.Auth(auth);
        }

        public Task CrearUsuario(UserEntity user, string token)
        {
            var userEntity = new UserEntity(user.Id, user.Name, user.Username, user.Password, user.IdRol, user.IdObra, token);
            return _userRepository.CrearUsuario(userEntity);
        }

        public async Task<IEnumerable<UserEntity>> ListarUsuarios() {

            var usuario = await _userRepository.ListarUsuario();
            return from u in usuario
                   select new UserEntity(u.Id, u.Name, u.Username, u.Password, u.IdRol, u.IdObra) { Obra = UserEntity.ObtenerObra(u.Obra), Rol = UserEntity.ObtenerRol(u.Rol), };
        }
    }
}
