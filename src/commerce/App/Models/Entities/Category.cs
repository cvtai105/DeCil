using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class Category
    {
        public int Id { get; set; } 
        public int? ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = "";
        public string? Image { get; set; }
        public string? Icon { get; set; }
        public IEnumerable<ProductCategory>? Products { get; set; }
        public IEnumerable<Category>? Children { get; set; }
        public Category? Parent { get; set; }
    }
}