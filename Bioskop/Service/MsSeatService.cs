using Bioskop.IService;
using Bioskop.Models;
using Bioskop.Models.Seat;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.Service
{
    public class MsSeatService : IMsSeatService
    {
        BioskopContext dbContext;

        public MsSeatService(BioskopContext _db)
        {
            dbContext = _db;
        }

        public SeatResponseDto GetSeat()
        {
            SeatResponseDto seat = new SeatResponseDto();
            List<MsSeat> seats = dbContext.MsSeats.ToList();
            List<SeatResponse> x = new List<SeatResponse>();
            seat.jumlah = seats.Count;
            seat.data = (from y in dbContext.MsSeats
                         join u in dbContext.MsStudios
                         on y.IdStudio equals u.IdStudio
                         select (new SeatResponse
                         {
                             NoSeat = y.NoSeat,
                             Status = y.Status,
                             NamaStudio = u.NamaStudio
                         })).ToList();
            return seat;
        }
    }
}
