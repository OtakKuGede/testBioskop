using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsTiket
    {
        [Key]
        public Guid IdTiket { get; set; }
        public Guid IdSeat { get; set; }
        public Guid IdPenayangan { get; set; }
    }
}
