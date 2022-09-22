using GalatasarayShop.Business.Services;
using GalatasarayShop.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GalatasarayShop.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetCategories();

            var viewModel = categories.Select(x => new CategoryViewModel
            {
                Id=x.Id,
                Name=x.Name,
            }).ToList();

            return View(viewModel);
        }
    }
}
