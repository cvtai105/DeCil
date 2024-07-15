using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Chưa đặt tên";
        public string? Picture { get; set; }
        public string Summary { get; set; } = "Chưa có mô tả";
        public string Description { get; set; } = "Chưa có mô tả";
        public int BasePrice { get; set; } 
        public int Stock { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public IEnumerable<Review> Reviews { get; set; } = [];
        public IEnumerable<ProductAttribute> Attributes { get; set; } = [];
        public IEnumerable<ProductImage> Images { get; set; } = [];
        public IEnumerable<ProductCategory> Categories { get; set; } = [];
        public Discount? Discount { get; set; }

    }
}