using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class CatalogController : Controller
    {
        private static List<CatalogItem> _catalogItems = new List<CatalogItem>
            {
                new(".NET Bot Black Sweatshirt", ".NET Bot Black Sweatshirt", 19.5M,  "/images/products/1.png"),
                new(".NET Black & White Mug", ".NET Black & White Mug", 8.50M, "/images/products/2.png"),
                new("Prism White T-Shirt", "Prism White T-Shirt", 12,  "/images/products/3.png"),
                new(".NET Foundation Sweatshirt", ".NET Foundation Sweatshirt", 12, "/images/products/4.png"),
                new("Roslyn Red Sheet", "Roslyn Red Sheet", 8.5M, "/images/products/5.png"),
                new(".NET Blue Sweatshirt", ".NET Blue Sweatshirt", 12, "/images/products/6.png"),
                new("Roslyn Red T-Shirt", "Roslyn Red T-Shirt",  12, "/images/products/7.png"),
                new("Kudu Purple Sweatshirt", "Kudu Purple Sweatshirt", 8.5M, "/images/products/8.png"),
                new( "Cup<T> White Mug", "Cup<T> White Mug", 12, "/images/products/9.png"),
                new(".NET Foundation Sheet", ".NET Foundation Sheet", 12, "/images/products/10.png"),
                new("Cup<T> Sheet", "Cup<T> Sheet", 8.5M, "/images/products/11.png"),
                new("Prism White TShirt", "Prism White TShirt", 12, "/images/products/12.png")
            };
        public IActionResult Index()
        {
            var catalogItemsViewModel = _catalogItems.Select(item => new CatalogItemViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                PictureUrl = item.PictureUrl,
                Price = item.Price
            }).ToList();



            return View(catalogItemsViewModel);
        }

        public IActionResult Details(int id)
        {
            var item = _catalogItems.FirstOrDefault(item => item.Equals(id));
            var result = new CatalogItemViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                PictureUrl = item.PictureUrl,
                Price = item.Price,
            };
            return View(result);
        }
    }
}
