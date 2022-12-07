using Microsoft.AspNetCore.Mvc;
using MyShop.Interfaces;
using MyShop.Models;
using MyShop.Services;

namespace MyShop.Controllers
{
    public class CatalogController : Controller
    {
        
        private readonly ICatalogItemViewModelService _catalogItemViewModelService;
        private readonly IRepository<CatalogItem> _catalogRepository;

        public CatalogController()
        {
            //TODO replace to IoC approach
            _catalogItemViewModelService = new CatalogItemViewModelService();
            _catalogRepository = new LocalCatalogItemRepository();
        }

        public IActionResult Index()
        {
            var catalogItemsViewModel = _catalogRepository.GetAll().Select(item => new CatalogItemViewModel()
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
            var item = _catalogRepository.GetById(id);
            if (item == null) return RedirectToAction("Index");
            
            var result = new CatalogItemViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                PictureUrl = item.PictureUrl,
                Price = item.Price,
            };
            return View(result);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var item = _catalogRepository.GetById(id);
            if (item == null) return RedirectToAction("Index");

            var result = new CatalogItemViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                PictureUrl = item.PictureUrl,
                Price = item.Price,
            };
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CatalogItemViewModel catalogItemViewModel)
        {
            try
            {
                _catalogItemViewModelService.UpdateCatalogItem(catalogItemViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}
