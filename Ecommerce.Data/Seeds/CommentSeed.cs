using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    internal class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment { Id = 1, ProductId = 1,  Comments = "simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry'" },
                new Comment { Id = 2, ProductId = 2,  Comments = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi ornare, risus id dapibus tincidunt, elit purus tristique " },
                new Comment { Id = 3, ProductId = 3,  Comments = "m, pharetra vel ipsum vel, interdum vehicula lectus. Maecenas id massa enim. Lorem ipsum dolor sit amet, consectetur a" },
                new Comment { Id = 4, ProductId = 4,  Comments = "m, pharetra vel ipsum vel, interdum vehicula lectus. Maecenas id massa enim. Lorem ipsum dolor sit amet, conse" },
                new Comment { Id = 5, ProductId = 1,  Comments = "m, pharetra vel ipsum vel, interdum vehicula lectus. Maecenas id massa enim. Lorem ipsum dolor sit amet, consectetur adipiscinn" },
                new Comment { Id = 6, ProductId = 1,  Comments = "nulla vulputate felis, et faucibus massa dolor nec nulla. Maecenas porta libero nisl, et facilisis lorem blandit vel. Mau" },
                new Comment { Id = 7, ProductId = 2,  Comments = "t ut ante id purus lobortis ullamcorper sit amet eu massa. Pellentesque orci nisl, dictum sed tempor ut, dignissim ac nibh. " },
                new Comment { Id = 8, ProductId = 3,  Comments = "ula sed, faucibus ut ex. Pellentesque vestibulum lorem et ipsum euismod tincidunt. Phasellus accumsan consequat risus, eget " },
                new Comment { Id = 9, ProductId = 4,  Comments = "sa viverra, sed facilisis diam elementum. Quisque nulla mauris, molestie nec convallis et, varius ac nibh. In hac habitasse plat" },
                new Comment { Id = 10, ProductId = 5,  Comments = "elit. Aliquam dapibus tristique i" },
                new Comment { Id = 11, ProductId = 6,  Comments = "nte tincidunt. Nullam maximus nisi turpis. Duis ipsum libero, aliquam quis nisi sagittis, tempor lacinia sapien. Maecenas gravi" },
                new Comment { Id = 12, ProductId = 7,  Comments = "nte tincidunt. Nullam maximus nisi turpis. Duis ipsum libero, aliquam quis nisi sagittis, tempor lacinia sapien. Maecenas gravid" },
                new Comment { Id = 13, ProductId = 8,  Comments = "nte tincidunt. Nullam maximus nisi turpis. Duis ipsum libero, aliquam quis nisi sagittis, tempor lacinia sapien. Maecenas grav" },
                new Comment { Id = 14, ProductId = 9,  Comments = "nte tincidunt. Nullam maximus nisi turpis. Duis ipsum libero, aliquam quis nisi sagittis, tempor lacinia sapien. Maecenas gravida neque vitae eros " });
        }
    }
}
