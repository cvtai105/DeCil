using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ProductId { get; set; } = null!;
        public int Quantity { get; set; }
        public int ItemPrice { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}