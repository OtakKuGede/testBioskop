using Bioskop.Models;
using System.Collections.Generic;

namespace Bioskop.IService
{
    public interface IMsUserService
    {
        List<MsUser> GetUser();
        MsUser RegisterUser(MsUserRequestDto req, string email);
    }
}
