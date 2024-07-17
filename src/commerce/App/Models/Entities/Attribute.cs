using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IEnumerable<ProductAttribute>? Products { get; set; } 
    }
}