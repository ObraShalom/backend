using ObraShalom.Domain.Models.Request;
using ObraShalom.Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraShalom.Service.Interfaces
{
    public interface IUserService
    {
        UserReponse Auth(AuthRequest auth);
    }
}
