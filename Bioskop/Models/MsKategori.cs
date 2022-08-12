using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsKategori
    {
        [Key]
        public Guid Idkategori { get; set; }
        public string NamaKategori { get; set; }
    }
}
