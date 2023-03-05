using Microsoft.AspNetCore.Mvc.Rendering;
using MyShop.Models;

namespace MyShop.Interfaces
{
    public interface ICatalogItemViewModelService
    {
        void UpdateCatalogItem(CatalogItemViewModel catalogItemViewModel);
        Task<CatalogIndexViewModel> GetCatalogItems(int? brandId, int? typeId/*, int? brandFilterApplied*/);

        Task<CatalogIndexViewModel> GetCatalogItems(int pageIndex, int itemPage, int? brandId, int? typeId);
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
