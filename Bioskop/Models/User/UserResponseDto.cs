using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioskop.Models.User
{
    public class UserResponseDto
    {
        public int total { get; set; }
        public List<UserResponse> data { get; set; }
    }
}
