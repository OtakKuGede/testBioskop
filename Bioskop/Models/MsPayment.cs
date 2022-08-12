using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsPayment
    {
        [Key]
        public Guid IdPayment { get; set; }
        public string NamaPayment { get; set; }
    }
}
