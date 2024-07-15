using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using app.Models.Entities;

namespace app.Models
{
    public class Discount
    {
        [Key]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public int Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Product? Product { get; set; }
        public DiscountType? Type { get; set; }
    }
}