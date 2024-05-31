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
    }
}
