using Bioskop.IService;
using Bioskop.Models;
using Bioskop.Models.Penayangan;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.Service
{
    public class MsPenayanganService : IMsPenayanganService
    {
        BioskopContext dbContext;

        public MsPenayanganService (BioskopContext _db)
        {
            dbContext = _db;
        }

        public PenayanganResponseDto GetPenayangan()
        {
            List<PenayanganResponse> tayang = new List<PenayanganResponse>();
            PenayanganResponseDto penayangan = new PenayanganResponseDto();
            List<MsPenayangan> x = dbContext.MsPenayangans.ToList();
            penayangan.jumlah = x.Count;
            penayangan.data = (from u in dbContext.MsPenayangans
                               join y in dbContext.MsFilms
                               on u.IdFilm equals y.IdFilm
                               join k in dbContext.MsStudios
                               on u.IdStudio equals k.IdStudio
                               join a in dbContext.MsBioskops
                               on k.IdBioskop equals a.IdBioskop
                               join b in dbContext.MsKategoris
                               on y.IdKategori equals b.Idkategori
                               select(new PenayanganResponse
                               {
                                   JudulFilm = y.JudulFilm,
                                   TanggalWaktu = u.TanggalWaktu,
                                   NamaStudio = k.NamaStudio,
                                   NamaLokasi = a.NamaLokasi,
                                   NamaKategori = b.NamaKategori
                               })).ToList();
            return penayangan;
        }
    }
}
