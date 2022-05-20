using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.EntityTypeBuilder
{
    public class CategoryTypeBuilder : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(i => i.Products).WithOne(i => i.Categories).HasForeignKey(i => i.CategoryId);

            builder.Property(p => p.CategoryName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(150);
        }
    }
}
