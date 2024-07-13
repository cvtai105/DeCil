using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? CategoryId { get; set; }
        public string Name { get; set; } = "Chưa đặt tên";
        public string? Picture { get; set; }
        public string? Summary { get; set; } = "Chưa có mô tả";
        public string Description { get; set; } = "Chưa có mô tả";
        public int Price { get; set; } = 0;
        public int DiscountValue { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int Sold { get; set; } = 0;
        public string? Tag { get; set; } = "Chưa có tag";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}