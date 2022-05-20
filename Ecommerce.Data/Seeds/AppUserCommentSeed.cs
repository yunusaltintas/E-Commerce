using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    public class AppUserCommentSeed : IEntityTypeConfiguration<AppUserComment>
    {
        public void Configure(EntityTypeBuilder<AppUserComment> builder)
        {
            builder.HasData(
                new AppUserComment { Id = 1, CommentId = 1, UserId = 1 },
                new AppUserComment { Id = 2, CommentId = 2, UserId = 1 },
                new AppUserComment { Id = 3, CommentId = 3, UserId = 1 },
                new AppUserComment { Id = 4, CommentId = 4, UserId = 1 },
                new AppUserComment { Id = 5, CommentId = 5, UserId = 1 },
                new AppUserComment { Id = 6, CommentId = 6, UserId = 1 },
                new AppUserComment { Id = 7, CommentId = 7, UserId = 1 },
                new AppUserComment { Id = 8, CommentId = 8, UserId = 1 },
                new AppUserComment { Id = 9, CommentId = 9, UserId = 1 },
                new AppUserComment { Id = 10, CommentId = 10, UserId = 1 }
                );
        }
    }
}
