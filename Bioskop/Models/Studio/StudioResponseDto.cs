using System.Collections.Generic;

namespace Bioskop.Models.Studio
{
    public class StudioResponseDto
    {
        public int jumlah { get; set; }
        public List<StudioResponse> data { get; set; }
    }
}
