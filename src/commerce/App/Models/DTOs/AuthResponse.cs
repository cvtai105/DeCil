using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.DTOs
{
    public class AuthResponse
    {
        public string UserId { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string? ProfileImage { get; set; }
    }
}