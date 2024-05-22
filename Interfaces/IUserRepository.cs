using backend.Models.Request;
using backend.Models.Response;

namespace backend.Interfaces
{
    public interface IUserRepository
    {
        UserReponse Auth(AuthRequest auth);
    }
}
