using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace app.Models
{
    [PrimaryKey(nameof(ProductId), nameof(CategoryId))]
    public class ProductCategory
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}