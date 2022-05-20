using Ecommerce.Data.Entities;
using Ecommerce.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Abstract
{
    public interface IProductService : IBaseService<Product>
    {
        Task<ReturnParameterModel<List<Product>>> GetAllProductAsync();
        Task<ReturnParameterModel<Product>> GetProductByIdAsync(int id);

    }
}
