using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsPemesanan
    {
        [Key]
        public Guid IdPemesanan { get; set; }
        public Guid IdUser { get; set; }
        public DateTime WaktuPemesanan { get; set; }
        public DateTime WaktuPembayaran { get; set; }
        public string Status { get; set; }
        public Guid IdPromo { get; set; }
        public Guid IdPayment { get; set; }
    }
}
