using Bioskop.IService;
using Bioskop.Models.Penayangan;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bioskop.Controllers
{
    [Route("api/MsPenayangan/")]
    [ApiController]
    public class MsPenayanganController : ControllerBase
    {
        private readonly IMsPenayanganService MsPenayanganService;

        public MsPenayanganController(IMsPenayanganService ser)
        {
            MsPenayanganService = ser;
        }

        [HttpGet]
        [Route("[Action]")]
        [Route("GetJadwal")]
        public PenayanganResponseDto GetPenayangan()
        {
            PenayanganResponseDto tayang = MsPenayanganService.GetPenayangan();
            return tayang;
        }
    }
}
