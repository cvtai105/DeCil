using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Entities
{
    public class Discount
    {
        [Key]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Product? Product { get; set; }
        public DiscountType? Type { get; set; }
    }
}