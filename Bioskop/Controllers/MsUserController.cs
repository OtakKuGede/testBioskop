using Bioskop.IService;
using Bioskop.Models;
using Bioskop.Models.User;
using Bioskop.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bioskop.Controllers
{
    [Route("api/MsUser/")]
    [ApiController]
    public class MsUserController : ControllerBase
    {
        private readonly IMsUserService MsUserService;

        public MsUserController(IMsUserService ser)
        {
            MsUserService = ser;
        }

        [HttpGet]
        [Route("[Action]")]
        [Route("GetUsers")]
        public UserResponseDto GetUser()
        {
            UserResponseDto returnData = MsUserService.GetUser();
            return returnData;
        }

        [HttpPost]
        [Route("[Action]")]
        [Route("Register")]
        public MsUser RegisterUser([FromBody]MsUserRequestDto req, string email)
        {
            return MsUserService.RegisterUser(req, email);
        }
    }
}
