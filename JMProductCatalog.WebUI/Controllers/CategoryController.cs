using JMProductCatalog.App.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JMProductCatalog.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return View(categories);
        }
    }
}
