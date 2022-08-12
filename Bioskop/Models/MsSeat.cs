using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsSeat
    {
        [Key]
        public Guid IdSeat { get; set; }
        public string NoSeat { get; set; }
        public string Status { get; set; }
        public Guid IdStudio { get; set; }
    }
}
