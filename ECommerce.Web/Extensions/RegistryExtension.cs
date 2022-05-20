using ECommerce.Repository;
using ECommerce.Service;
using ECommerce.Service.Abstract;
using ECommerce.Service.Concrate;

namespace ECommerce.Web.Extensions
{
    public static class RegistryExtension
    {
        public static void AddRegistry(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
