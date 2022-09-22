using GalatasarayShop.Business.Services;
using GalatasarayShop.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GalatasarayShop.WebUI.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {

        private readonly IProductService _productService;

        public ProductsViewComponent(IProductService productService)
        {
            _productService=productService;
        }


        public IViewComponentResult Invoke(int? categoryId = null)
        {
            var products = _productService.GetProducts(categoryId);

            var viewModel = products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                UnitPrice = x.UnitPrice,
                ImagePath = x.ImagePath,
                Description = x.Description
            }).ToList();

            return View(viewModel);
        }
    }
}
