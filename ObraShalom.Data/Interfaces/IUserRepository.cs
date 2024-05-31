
namespace ObraShalom.Domain.Interfaces
{
    public interface IUserRepository
    {
        UserReponse Auth(AuthRequest auth);
    }
}
