using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.EntityTypeBuilder
{
    public class BrandTypeBuilder : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasMany(i => i.Products).WithOne(i => i.Brands).HasForeignKey(i => i.BrandId);

            builder.Property(p => p.BrandName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(150);
        }
    }
}
