using Bioskop.IService;
using Bioskop.Models;
using Bioskop.Models.Bioskop;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.Service
{
    public class MsBioskopService : IMsBioskopService
    {
        BioskopContext dbContext;

        public MsBioskopService (BioskopContext _db)
        {
            dbContext = _db;
        }

        public BioskopResponseDto GetBioskop()
        {
            BioskopResponseDto bioskopResponseDto = new BioskopResponseDto();
            List<BioskopResponse> bioskop = new List<BioskopResponse>();
            List<MsBioskop> bio = dbContext.MsBioskops.ToList();
            bioskopResponseDto.jumlah = bio.Count;
            bioskopResponseDto.data = bioskop;
            foreach (MsBioskop u in bio )
            {
                BioskopResponse skop = new BioskopResponse();
                skop.NamaLokasi = u.NamaLokasi;
                bioskop.Add(skop);
            }
            return bioskopResponseDto;
            
        }
    }
}
