using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace app.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Category { get; set; }
        // public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
    }
}