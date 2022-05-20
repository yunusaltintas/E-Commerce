using Ecommerce.Data.Entities;
using Ecommerce.Data.EntityTypeBuilder;
using Ecommerce.Data.Seeds;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class ECommerceDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<AppUserComment> AppUserComment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new CategoryTypeBuilder())
                .ApplyConfiguration(new ProductTypeBuilder())
                .ApplyConfiguration(new BrandTypeBuilder())
                .ApplyConfiguration(new ColorTypeBuilder())
                .ApplyConfiguration(new SizeTypeBuilder())
                .ApplyConfiguration(new CommentTypeBuilder());

            modelBuilder
               .ApplyConfiguration(new RoleSeed())
               .ApplyConfiguration(new UserSeed())
               .ApplyConfiguration(new CategorySeed())
               .ApplyConfiguration(new BrandSeed())
               .ApplyConfiguration(new ColorSeed())
               .ApplyConfiguration(new SizeSeed())
               .ApplyConfiguration(new ProductSeed())
               .ApplyConfiguration(new CommentSeed())
               .ApplyConfiguration(new AppUserCommentSeed());


            base.OnModelCreating(modelBuilder);
        }

    }
}
