using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsFilm
    {
        [Key]
        public Guid IdFilm { get; set; }
        public string JudulFilm { get; set; }
        public string Sinopsis { get; set; }
        public string Cast { get; set; }
        public string Director { get; set; }
        public Guid IdKategori { get; set; }
    }
}
