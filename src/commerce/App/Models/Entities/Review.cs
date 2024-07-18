using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string ProductId { get; set; } = null!;
        public int UserId { get; set; }
        [Required]
        public string? Content { get; set; }
        [Range(1, 5)]
        [Required]
        public int? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int? ParentId { get; set; }
        public Review? Parent { get; set; }
        public IEnumerable<Review>? Children { get; set; } = [];
        public Product? Product { get; set; }
        public User? User { get; set; }
    }
}