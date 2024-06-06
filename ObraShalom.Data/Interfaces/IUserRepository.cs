
using ObraShalom.Domain.Dto;
using ObraShalom.Domain.Entities;

namespace ObraShalom.Domain.Interfaces
{
    public interface IUserRepository
    {
        UserReponse Auth(AuthRequest auth);
        Task CrearUsuario(UserEntity usuario);
        Task<IEnumerable<UserDto>> ListarUsuario();
        Task ActualizarUsuario(UserEntity usuario);
    }
}
