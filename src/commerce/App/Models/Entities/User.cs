using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string? Password { get; set; }
        public string? Salt { get; set; }
        public string? Phone { get; set; }
        public string? Name { get; set; }
        public string? Avatar { get; set; }
        public IEnumerable<Order>? Orders { get; set; } = [];
        public IEnumerable<Review>? Reviews { get; set; } = [];
        public IEnumerable<UserAddress>? Addresses { get; set; } = [];
    }
}