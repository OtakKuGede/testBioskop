using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsPromo
    {
        [Key]
        public Guid IdPromo { get; set; }
        public string NamaPromo { get; set; }
        public DateTime MulaiPromo { get; set; }
        public DateTime AkhirPromo { get; set; }
    }
}
