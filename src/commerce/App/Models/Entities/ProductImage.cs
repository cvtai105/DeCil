using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class ProductImage
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }
        public int ImageId { get; set; }
        public int Order { get; set; }
        public Product? Product { get; set; }
        public Image? Image { get; set; }
    }
}