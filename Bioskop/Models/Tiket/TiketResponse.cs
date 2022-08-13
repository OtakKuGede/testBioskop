using System;

namespace Bioskop.Models.Tiket
{
    public class TiketResponse
    {
        public string NamaLokasi { get; set; }
        public string JudulFilm { get; set; }
        public DateTime TanggalWaktu { get; set; }
        public string NoSeat { get; set; }
        public int Harga { get; set; }

    }
}
