using Bioskop.IService;
using Bioskop.Models.Seat;
using Bioskop.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bioskop.Controllers
{
    [Route("api/MsSeat")]
    [ApiController]
    public class MsSeatController : ControllerBase
    {
        private readonly IMsSeatService MsSeatService;

        public MsSeatController(IMsSeatService ser)
        {
            MsSeatService = ser;
        }

        [HttpGet]
        [Route("[Action]")]
        [Route("GetSeats")]
        public SeatResponseDto GetSeat()
        {
            SeatResponseDto res = MsSeatService.GetSeat();
            return res;
        }
    }
}
