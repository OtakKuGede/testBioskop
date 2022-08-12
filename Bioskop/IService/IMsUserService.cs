using Bioskop.Models;
using Bioskop.Models.User;
using System.Collections.Generic;

namespace Bioskop.IService
{
    public interface IMsUserService
    {
        UserResponseDto GetUser();
        MsUser RegisterUser(MsUserRequestDto req, string email);
    }
}
