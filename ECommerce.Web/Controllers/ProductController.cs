using Ecommerce.Data.Entities;
using ECommerce.Service;
using ECommerce.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Web.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IBaseService<Category> _categoryService;
        private readonly IProductService _productService;

        public ProductController(IBaseService<Category> categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var result = await _productService.GetAllAsync();

            return PartialView(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductDetail(int id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            return View(result);
        }

    }
}
