using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    public class BrandSeed : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { Id = 1, BrandName = "Adidas" },
                new Brand { Id = 2, BrandName = "LTB" },
                new Brand { Id = 3, BrandName = "Kinetix" },
                new Brand { Id = 4, BrandName = "Vodafone" },
                new Brand { Id = 5, BrandName = "Kacuv" },
                new Brand { Id = 6, BrandName = "Sirma" },
                new Brand { Id = 7, BrandName = "Efes" },
                new Brand { Id = 8, BrandName = "ABC" },
                new Brand { Id = 9, BrandName = "Fit" }

                );
        }
    }
}
