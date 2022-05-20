using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.EntityTypeBuilder
{
    public class ColorTypeBuilder : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasMany(i => i.Products).WithOne(i => i.Colors).HasForeignKey(i => i.ColorId);

            builder.Property(p => p.ColorName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(150);
        }
    }
}
