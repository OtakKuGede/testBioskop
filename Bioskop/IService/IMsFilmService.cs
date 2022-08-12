using Bioskop.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioskop.IService
{
    public interface IMsFilmService
    {
        FilmResponseDto GetFilm();
    }
}
