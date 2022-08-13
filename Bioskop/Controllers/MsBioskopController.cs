using Bioskop.IService;
using Bioskop.Models.Bioskop;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bioskop.Controllers
{
    [Route("api/MsBioskop/")]
    [ApiController]
    public class MsBioskopController : ControllerBase
    {
        private readonly IMsBioskopService MsBioskopService;

        public MsBioskopController(IMsBioskopService msBioskopService)
        {
            MsBioskopService = msBioskopService;
        }

        [HttpGet]
        [Route("[Action]")]
        [Route("GetBioskops")]
        public BioskopResponseDto GetBioskop()
        {
            BioskopResponseDto bb = MsBioskopService.GetBioskop();
            return bb;
        }
    }
    }
