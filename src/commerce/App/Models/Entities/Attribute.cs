using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Attribute
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Biến thể";
        public IEnumerable<ProductAttribute> Products { get; set; } = [];
    }
}