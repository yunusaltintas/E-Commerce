using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.EntityTypeBuilder
{
    public class SizeTypeBuilder : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasMany(i => i.Products).WithOne(i => i.Sizes).HasForeignKey(i => i.SizeId);

            builder.Property(p => p.BodySize)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(150);
        }
    }
}
