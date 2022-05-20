using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    public class ColorSeed : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color { Id = 1, ColorName = "Blue" },
                new Color { Id = 2, ColorName = "Red" },
                new Color { Id = 3, ColorName = "White" },
                new Color { Id = 4, ColorName = "Black" },
                new Color { Id = 5, ColorName = "Green" },
                new Color { Id = 6, ColorName = "Orrange" },
                new Color { Id = 7, ColorName = "Pink" },
                new Color { Id = 8, ColorName = "Pruple" },
                new Color { Id = 9, ColorName = "Brown" }
                );
        }
    }
}
