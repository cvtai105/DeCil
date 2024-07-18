using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App.Models.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(ImageId))]
    public class ProductImage
    {
        public string ProductId { get; set; } = null!;
        public string ImageId { get; set; } = null!;
        public int Order { get; set; }
        public Product? Product { get; set; }
        public Image? Image { get; set; }
    }
}