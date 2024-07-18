using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.DTOs
{
    public class ProductPagination
    {
        int Page { get; set; }
        int PageSize { get; set; }
        string? Search { get; set; }
        int? CategoryId { get; set; }
    }
}