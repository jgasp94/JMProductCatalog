using JMProductCatalog.App.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JMProductCatalog.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var services = await _service.GetProductsAsync();
            return View(services);
        }
    }
}
