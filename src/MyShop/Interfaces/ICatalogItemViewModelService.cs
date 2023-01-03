using MyShop.Models;

namespace MyShop.Interfaces
{
    public interface ICatalogItemViewModelService
    {
        void UpdateCatalogItem(CatalogItemViewModel catalogItemViewModel);
        Task<IEnumerable<CatalogItemViewModel>> GetCatalogItems();
    }
}
