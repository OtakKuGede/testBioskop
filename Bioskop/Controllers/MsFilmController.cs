using Bioskop.IService;
using Bioskop.Models.Film;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioskop.Controllers
{
    [Route("api/MsFilm/")]
    [ApiController]
    public class MsFilmController : ControllerBase
    {
        private readonly IMsFilmService MsFilmService;

        public MsFilmController(IMsFilmService ser)
        {
            MsFilmService = ser;
        }

        [HttpGet]
        [Route("[Action]")]
        [Route("GetFilms")]
        public FilmResponseDto GetFilm()
        {
            FilmResponseDto returnData = MsFilmService.GetFilm();
            return returnData;
        }

       
    }
}
