using Microsoft.AspNetCore.Mvc;
using MyShop.ApplicationCore.Interfaces;
using MyShop.Interfaces;
using MyShop.Models;
using MyShop.Services;

namespace MyShop.Controllers
{
    public class CatalogController : Controller
    {
        
        private readonly ICatalogItemViewModelService _catalogItemViewModelService;
        private readonly IRepository<CatalogItem> _catalogRepository;

        public CatalogController(IRepository<CatalogItem> catalogRepository, ICatalogItemViewModelService catalogItemViewModelService)
        {
            //TODO replace to IoC approach
            _catalogItemViewModelService = catalogItemViewModelService;
            _catalogRepository = catalogRepository;
        }

        public async Task<IActionResult> Index()
        {
            var catalogItemsViewModel = await _catalogItemViewModelService.GetCatalogItems();
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
