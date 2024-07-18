using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using App.Models.DTOs;
using App.Models.Entities;

namespace App.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        private readonly CloudinaryService _cloudinaryService;
        public ProductService( AppDbContext context, CloudinaryService cloudinaryService)
        {
            _context = context;
            _cloudinaryService = cloudinaryService;
        }

        public async Task<ProductCreatedResponse> CreateProduct(ProductCreateRequest productReq)
        {
            //upload images
            var uploadResults = await _cloudinaryService.UploadImages(productReq.Images);

            //TODO: handle delete image if upload to database failed
            //add images to database
            var images = uploadResults.Select(image => new Image
            {
                Link = image.Url,
                Id = image.PublicId,
                Name = image.Name
            }).Where(image => image.Link != null);
            _context.Images.AddRange(images);

            //add product to database
            var newProduct = new Product
            {
                Name = productReq.Name,
                Picture = images.FirstOrDefault()?.Link,
                Summary = productReq.Summary?? "Chưa có mô tả",
                Stock = productReq.Stock,
                Description = productReq.Description?? "Chưa có mô tả",
                BasePrice = productReq.Price,
            };
            _context.Products.Add(newProduct);

            //add product attributes to database
            foreach(var attribute in productReq.Attributes)
            {
                attribute.ProductId = newProduct.Id;
            }
            _context.ProductAttributes.AddRange(productReq.Attributes);

            //add product categories to database
            var productCategories = productReq.CategoryIds.Select(categoryId => new ProductCategory
            {
                ProductId = newProduct.Id,
                CategoryId = categoryId
            });
            _context.ProductCategories.AddRange(productCategories);

            //add product images to database
            var productImagesEntities = images.Select((image, index) => new ProductImage
            {
                ProductId = newProduct.Id,
                ImageId = image.Id,
                Order = index
            });

            await _context.SaveChangesAsync();

            var productCreatedResponse = new ProductCreatedResponse
            {
                ImageUrls = uploadResults.Select(image => image.Url ?? "lỗi"),
                ProductId = newProduct.Id.ToString(),
                ProductName = newProduct.Name
            };

            return productCreatedResponse;

        }
        

        // public async Task<IEnumerable<Product> GetPagination(int page, int limit)
        // {
        //     return await _context.Products.Skip((page - 1) * limit).Take(limit).ToListAsync();
        // }
    }
}