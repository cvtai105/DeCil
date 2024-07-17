using App.Models.Entities;
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
        public DbSet<App.Models.Entities.Attribute> Attributes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Điện thoại" },
                new Category { Id = 2, Name = "Máy tính bảng" },
                new Category { Id = 3, Name = "Laptop" },
                new Category { Id = 4, Name = "Phụ kiện" }
            );

            modelBuilder.Entity<DiscountType>().HasData(
                new DiscountType { Id = 1, Name = "Giảm giá theo %" },
                new DiscountType { Id = 2, Name = "Giảm giá theo tiền"}
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Iphone 12", BasePrice = 10000000, Stock = 100 },
                new Product { Id = 2, Name = "Samsung Galaxy S21", BasePrice = 12000000, Stock = 100 },
                new Product { Id = 3, Name = "Xiaomi Redmi Note 10", BasePrice = 5000000, Stock = 100 },
                new Product { Id = 4, Name = "Apple Watch", BasePrice = 20000000, Stock = 100 }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { ProductId = 1, CategoryId = 1 },
                new ProductCategory { ProductId = 2, CategoryId = 2 },
                new ProductCategory { ProductId = 3, CategoryId = 3 },
                new ProductCategory { ProductId = 4, CategoryId = 4 }
            );

            modelBuilder.Entity<Admin>().HasData(
                new Admin { Email = "admin@gmail.com", Password = "admin",  }
            );

        }

    }

}