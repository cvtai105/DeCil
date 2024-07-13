using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ParentId { get; set; }

        public string Name { get; set; } = "Chưa đặt tên";
        public string? Slug { get; set; } = "";
        public string Description { get; set; } = "Chưa có mô tả";
        public string Image { get; set; } = "default.jpg";
        public string Icon { get; set; } = "default.jpg";
        public string Tag { get; set; } = "Chưa có tag";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        
    }
}