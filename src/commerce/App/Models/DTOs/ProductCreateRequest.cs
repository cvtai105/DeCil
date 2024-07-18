using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models.Entities;

namespace App.Models.DTOs
{
    public class ProductCreateRequest
    {
        public string Name { get; set; } = null!;
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public ProductAttribute[] Attributes { get; set; } = [];
        public int[] CategoryIds { get; set; } = [];
        public IFormFile[] Images { get; set; } = [];
    }
}