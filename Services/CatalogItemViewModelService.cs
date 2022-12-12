using MyShop.Interfaces;
using MyShop.Models;

namespace MyShop.Services
{
    public class CatalogItemViewModelService : ICatalogItemViewModelService
    {
        private readonly IRepository<CatalogItem> _catalogItemRepository;

        public CatalogItemViewModelService(IRepository<CatalogItem> catalogItemRepository)
        {
            _catalogItemRepository = catalogItemRepository;
        }
        public void UpdateCatalogItem(CatalogItemViewModel viewModel)
        {
            var existingCatalogItem = _catalogItemRepository.GetById(viewModel.Id);

            if (existingCatalogItem is null) throw new Exception($"Catalog item {viewModel.Id} not found");

            CatalogItem.CatalogItemDetails detail = new(viewModel.Name, viewModel.Price);
            existingCatalogItem.UpdateDetails(detail);

        }
    }
}
