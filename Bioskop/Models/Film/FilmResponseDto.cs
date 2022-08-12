using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioskop.Models.Film
{
    public class FilmResponseDto
    {
        public int total { get; set; }
        public List<FilmResponse> data { get; set; }
    }
}
