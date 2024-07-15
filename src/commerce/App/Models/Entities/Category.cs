using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace app.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ParentId { get; set; }
        public string Name { get; set; } = "Chưa đặt tên";
        public string Description { get; set; } = "Chưa có mô tả";
        public string? Image { get; set; }
        public string? Icon { get; set; }
        public IEnumerable<ProductCategory> Products { get; set; } = [];
    }
}