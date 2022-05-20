using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, CategoryName = "Clothes" },
                new Category { Id = 2, CategoryName = "Legumes" },
                new Category { Id = 3, CategoryName = "Technology" },
                new Category { Id = 4, CategoryName = "Home/Life" },
                new Category { Id = 5, CategoryName = "Frozen Food" },
                new Category { Id = 6, CategoryName = "Watch" },
                new Category { Id = 7, CategoryName = "Music" },
                new Category { Id = 8, CategoryName = "Luxury" },
                new Category { Id = 9, CategoryName = "Shoe" }
                );
        }
    }
}
