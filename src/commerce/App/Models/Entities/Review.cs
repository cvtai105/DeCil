using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Review
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        [Required]
        public string? Content { get; set; }
        [Range(1, 5)]
        [Required]
        public int? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Product? Product { get; set; }
        
    }
}