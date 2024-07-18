using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.DTOs
{
    public class ProductCreatedResponse
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public IEnumerable<string> ImageUrls { get; set; } = null!; 
    }
}