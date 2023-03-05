using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using MyShop.Interfaces;
using MyShop.Models;

namespace MyShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICatalogItemViewModelService _catalogItemViewModelService;
        public CatalogIndexViewModel CatalogModel { get; set; } = new();

        public IndexModel(ICatalogItemViewModelService catalogItemViewModelService)
        {
            _catalogItemViewModelService = catalogItemViewModelService;
        }
        
        public async Task OnGet(CatalogIndexViewModel catalogModel, int? pageId)
        {
            CatalogModel = await _catalogItemViewModelService.GetCatalogItems (pageId ?? 0, Constants.ITEMS_PER_PAGE, catalogModel.BrandFilterApplied, catalogModel.TypesFilterApplied);
        }
    }
}
