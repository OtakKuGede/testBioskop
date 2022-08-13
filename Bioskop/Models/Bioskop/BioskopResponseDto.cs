using System.Collections.Generic;

namespace Bioskop.Models.Bioskop
{
    public class BioskopResponseDto
    {
        public int jumlah {get; set;}
        public List<BioskopResponse> data { get; set; }
    }
}
