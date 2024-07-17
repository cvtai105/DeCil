using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class Order
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public User? User { get; set; }
        public IEnumerable<OrderItem>? Items { get; set; } = [];
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ShippedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public string? TrackingNumber { get; set; }
        public string? Status { get; set; }
        
    }
}