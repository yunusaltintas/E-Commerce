using Ecommerce.Data.Entities;
using Ecommerce.Data.ResponseModel;
using ECommerce.Repository;
using ECommerce.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Concrate
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IRepository<Product> _repository;
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
            _repository = repository;
        }

        public async Task<ReturnParameterModel<List<Product>>> GetAllProductAsync()
        {
            var result = await _repository.Query().Include(x => x.Categories).Include(x => x.Brands).Include(x => x.Colors).Include(x => x.Sizes).ToListAsync();
            if (result == null)
                return new ReturnParameterModel<List<Product>>("Errors");
            return new ReturnParameterModel<List<Product>>(result);
        }

        public async Task<ReturnParameterModel<Product>> GetProductByIdAsync(int id)
        {
            var result = await _repository.Query().Where(x => x.Id == id).Include(x => x.Categories).Include(x => x.Brands).Include(x => x.Colors).Include(x => x.Sizes).Include(x => x.Comments).ThenInclude(x=>x.Users).ThenInclude(x=>x.User).FirstOrDefaultAsync();
            if (result == null)
                return new ReturnParameterModel<Product>("Errors");
            return new ReturnParameterModel<Product>(result);
        }
    }
}
