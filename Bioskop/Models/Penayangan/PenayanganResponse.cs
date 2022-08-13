using System;

namespace Bioskop.Models.Penayangan
{
    public class PenayanganResponse
    {
        public string JudulFilm { get; set; }
        public string NamaLokasi { get; set; }
        public string NamaStudio { get; set; }
        public string NamaKategori { get; set; }
        public DateTime TanggalWaktu { get; set; }

    }
}
