using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Bioskop.Models
{
    public partial class MsUser
    {
        
        public Guid IdUser { get; set; }
        public string Nama { get; set; }
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string NoTelepon { get; set; }
        public string Alamat { get; set; }
        public string Kota { get; set; }
    }
}
