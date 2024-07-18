using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class Image
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = "";
        public string? Link { get; set; }
        public IEnumerable<ProductImage>? Products { get; set; } = [];
    }
}