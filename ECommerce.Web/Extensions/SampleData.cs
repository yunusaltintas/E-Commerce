using Ecommerce.Data;
using Ecommerce.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Web.Extensions
{
    public static class SampleData
    {
        public static void DatabaseInitialize(this IApplicationBuilder builder)
        {

            using var serviceScope =
                builder.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();

            using var context = serviceScope.ServiceProvider.GetService<ECommerceDbContext>();

            if (context == null) return;
             DatabaseMigration(context);

            var roleContext = context.Set<AppRole>();
            var userContext = context.Set<AppUser>();

            var roles = roleContext.Select(p => p.Name).ToArray();
            var user = userContext.FirstOrDefault();

            _ = AssignRoles(serviceScope, user.Email, roles);

            context.SaveChanges();
        }

        public static IdentityResult AssignRoles(IServiceScope? serviceScope, string email, string[] roles)
        {
            UserManager<AppUser> _userManager = (UserManager<AppUser>)serviceScope.ServiceProvider.GetService(typeof(UserManager<AppUser>));
            AppUser user = _userManager.FindByEmailAsync(email).Result;
            var result = _userManager.AddToRolesAsync(user, roles).Result;

            return result;
        }

        private static void DatabaseMigration(ECommerceDbContext context)
        {
            context.Database.Migrate();
        }
    }
}
