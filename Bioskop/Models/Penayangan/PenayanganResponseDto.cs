using System.Collections.Generic;

namespace Bioskop.Models.Penayangan
{
    public class PenayanganResponseDto
    {
        public int jumlah { get; set; }
        public List<PenayanganResponse> data { get; set; }
    }
}
