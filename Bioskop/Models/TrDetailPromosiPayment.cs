using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class TrDetailPromosiPayment
    {
        [Key]
        public Guid IdDetailPromosiPayment { get; set; }
        public Guid IdPromo { get; set; }
        public Guid IdPayment { get; set; }
        public int? MinimumPayment { get; set; }
        public int? PotonganHarga { get; set; }
        public Guid IdFilm { get; set; }
    }
}
