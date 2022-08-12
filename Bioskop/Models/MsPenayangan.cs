using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsPenayangan
    {
        [Key]
        public Guid IdPenayangan { get; set; }
        public Guid IdFilm { get; set; }
        public Guid IdStudio { get; set; }
        public DateTime TanggalWaktu { get; set; }
    }
}
