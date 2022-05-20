using Ecommerce.Data;
using Ecommerce.Data.Entities;
using ECommerce.Web.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddAuthentication();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ECommerceDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddIdentity<AppUser, AppRole>(p =>
{
    p.Password.RequireDigit = false;
    p.Password.RequiredLength = 3;
    p.Password.RequireLowercase = false;
    p.Password.RequireNonAlphanumeric = false;
    p.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<ECommerceDbContext>();
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme,
opt =>
{
    opt.LoginPath = "/Login/Index";
    opt.LogoutPath = "/Login/Logout";
    opt.Cookie = new CookieBuilder
    {
        Name = "AspNetCoreIdentityCookieYEA",
        HttpOnly = true,
        SecurePolicy = CookieSecurePolicy.Always
    };
    opt.SlidingExpiration = true;
    opt.ExpireTimeSpan = TimeSpan.FromMinutes(120);
});

builder.Services.AddRegistry();

builder.Services.AddMvc();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/Home/NotFound", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.DatabaseInitialize();

app.Run();
