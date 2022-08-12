using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsStudio
    {
        [Key]
        public Guid IdStudio { get; set; }
        public Guid IdBioskop { get; set; }
        public string NamaStudio { get; set; }
        public string TypeStudio { get; set; }
        public int HargaWeekend { get; set; }
        public int HargaHariBiasa { get; set; }
    }
}
