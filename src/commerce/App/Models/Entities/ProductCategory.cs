using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace App.Models.Entities
{
    [PrimaryKey(nameof(ProductId), nameof(CategoryId))]
    public class ProductCategory
    {
        public string ProductId { get; set; } = null!;
        public int CategoryId { get; set; }
        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}