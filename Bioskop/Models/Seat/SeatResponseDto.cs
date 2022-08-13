using System.Collections.Generic;

namespace Bioskop.Models.Seat
{
    public class SeatResponseDto
    {
        public int jumlah { get; set; }
        public List<SeatResponse> data { get; set; }
    }
}
