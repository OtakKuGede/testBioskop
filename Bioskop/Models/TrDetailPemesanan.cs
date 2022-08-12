using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class TrDetailPemesanan
    {
        [Key]
        public Guid IdDetailPemesanan { get; set; }
        public Guid IdPemesanan { get; set; }
        public Guid IdTiket { get; set; }
    }
}
