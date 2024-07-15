using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Image
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Chưa đặt tên";
        public string? Link { get; set; }
        public IEnumerable<ProductImage> Products { get; set; } = [];
    }
}