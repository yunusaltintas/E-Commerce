using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, ProductName = "NetCore", Price = 101.6, CategoryId = 1, ColorId = 1, BrandId = 2, SizeId = 2, FilePic = null },
                new Product { Id = 2, ProductName = "Mvc", Price = 80, CategoryId = 2, ColorId = 4, BrandId = 1, SizeId = 1, FilePic = null },
                new Product { Id = 3, ProductName = "Docker", Price = 90.90, CategoryId = 4, ColorId = 3, BrandId = 1, SizeId = 1, FilePic = null },
                new Product { Id = 4, ProductName = "Angular", Price = 41.41, CategoryId = 3, ColorId = 2, BrandId = 5, SizeId = 4, FilePic = null },
                new Product { Id = 5, ProductName = "Cache", Price = 16.54, CategoryId = 6, ColorId = 7, BrandId = 6, SizeId = 5, FilePic = null },
                new Product { Id = 6, ProductName = "React", Price = 84, CategoryId = 3, ColorId = 8, BrandId = 8, SizeId = 6, FilePic = null },
                new Product { Id = 7, ProductName = "Vue", Price = 12, CategoryId = 6, ColorId = 9, BrandId = 9, SizeId = 4, FilePic = null },
                new Product { Id = 8, ProductName = "Swagger", Price = 41, CategoryId = 9, ColorId = 3, BrandId = 3, SizeId = 8, FilePic = null },
                new Product { Id = 9, ProductName = "Redis", Price = 34, CategoryId = 8, ColorId = 5, BrandId = 2, SizeId = 9, FilePic = null },
                new Product { Id = 10, ProductName = "Ajax", Price = 12, CategoryId = 4, ColorId = 6, BrandId = 6, SizeId = 7, FilePic = null },
                new Product { Id = 11, ProductName = "Mongo", Price = 63, CategoryId = 5, ColorId = 1, BrandId = 7, SizeId = 6, FilePic = null },
                new Product { Id = 12, ProductName = "Postgre", Price = 71, CategoryId = 7, ColorId = 3, BrandId = 1, SizeId = 6, FilePic = null },
                new Product { Id = 13, ProductName = "Rest", Price = 4, CategoryId = 8, ColorId = 1, BrandId = 7, SizeId = 2, FilePic = null },
                new Product { Id = 14, ProductName = "Api", Price = 8, CategoryId = 4, ColorId = 5, BrandId = 1, SizeId = 4, FilePic = null }
                );
        }
    }
}
