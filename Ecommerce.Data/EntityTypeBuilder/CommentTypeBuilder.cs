using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.EntityTypeBuilder
{
    public class CommentTypeBuilder : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(p => p.Comments)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(1050);
        }
    }
}
