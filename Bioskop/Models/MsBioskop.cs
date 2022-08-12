using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsBioskop
    {
        [Key]
        public Guid IdBioskop { get; set; }
        public string NamaLokasi { get; set; }
    }
}
