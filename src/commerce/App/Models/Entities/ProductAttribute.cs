using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ProductAttribute
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public Guid AttributeId { get; set; }
        public string Value { get; set; } = "-";
        public Guid ImageId { get; set; }   
        public int PriceDif { get; set; } = 0;

        public Product? Product { get; set; }
        public Attribute? Attribute { get; set; }
    }
}