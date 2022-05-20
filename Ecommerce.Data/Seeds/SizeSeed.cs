using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    public class SizeSeed : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size { Id = 1, BodySize = "1" },
                new Size { Id = 2, BodySize = "2" },
                new Size { Id = 3, BodySize = "3" },
                new Size { Id = 4, BodySize = "4" },
                new Size { Id = 5, BodySize = "5" },
                new Size { Id = 6, BodySize = "6" },
                new Size { Id = 7, BodySize = "7" },
                new Size { Id = 8, BodySize = "8" },
                new Size { Id = 9, BodySize = "9" }
                );
        }
    }
}
