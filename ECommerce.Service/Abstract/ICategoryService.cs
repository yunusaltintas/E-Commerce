using Ecommerce.Data.Entities;
using Ecommerce.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Abstract
{
    public interface ICategoryService
    {
        Task<ReturnParameterModel<List<Category>>> GetAllCategoryAsync();
        Task<ReturnParameterModel<List<Category>>> GetAllCategoryOrderLetterAsync();
        //Task<ReturnModel> AddCategory(AddCategoryViewModel AddCategoryViewModel);
        Task<ReturnParameterModel<Category>> GetCategoryByIdAsync(int id);
        //Task<ReturnParameterModel<Category>> UpdateCategory(UpdateCategoryViewModel updateCategoryViewModel);
        Task<ReturnModel> DeleteCategoryAsync(int id);
    }
}
