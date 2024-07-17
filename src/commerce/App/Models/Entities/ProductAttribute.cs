using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class ProductAttribute
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; } = "-";
        public int ImageId { get; set; }   
        public int PriceDif { get; set; } = 0;

        public Product? Product { get; set; }
        public Attribute? Attribute { get; set; }
    }
}