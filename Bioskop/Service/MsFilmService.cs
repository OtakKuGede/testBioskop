using Bioskop.IService;
using Bioskop.Models;
using Bioskop.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioskop.Service
{
    public class MsFilmService : IMsFilmService
    {
        BioskopContext dbContext;

        public MsFilmService(BioskopContext _db)
        {
            dbContext = _db;
        }

        public FilmResponseDto GetFilm()
        {
            List<MsFilm> msFilms = dbContext.MsFilms.ToList();
            FilmResponseDto filmResponseDto = new FilmResponseDto();
            filmResponseDto.total = msFilms.Count();
            filmResponseDto.data = (from f in dbContext.MsFilms
                                    join k in dbContext.MsKategoris
                                    on f.IdKategori equals k.Idkategori
                                    select (new FilmResponse { filmName = f.JudulFilm, kategoriName = k.NamaKategori })).ToList();
            return filmResponseDto;
        }
    }
}
