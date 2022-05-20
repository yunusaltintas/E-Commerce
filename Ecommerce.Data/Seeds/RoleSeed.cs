using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Seeds
{
    public class RoleSeed : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole { Id = 1, Name = "SysAdmin", NormalizedName = "SYSADMIN", ConcurrencyStamp = "a7d4bfdd-7b62-48bd-8f84-142b52a1b5f5" },
                new AppRole { Id = 2, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "09c1c7d3-03d0-4c09-a306-74b12adbb06d" },
                new AppRole { Id = 3, Name = "Customer", NormalizedName = "CUSTOMER", ConcurrencyStamp = "9e63c39f-6224-4b26-9ba5-9c092d439a25" }
                );
        }
    }
}
