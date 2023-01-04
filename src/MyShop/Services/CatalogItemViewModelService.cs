﻿using MyShop.ApplicationCore.Entities;
using MyShop.ApplicationCore.Interfaces;
using MyShop.Interfaces;
using MyShop.Models;

namespace MyShop.Services
{
    public class CatalogItemViewModelService : ICatalogItemViewModelService
    {
        private readonly IRepository<CatalogItem> _catalogItemRepository;
        private readonly IAppLogger<CatalogItemViewModelService> _logger;

        public CatalogItemViewModelService(IRepository<CatalogItem> catalogItemRepository,
            IAppLogger<CatalogItemViewModelService> logger)
        {
            _catalogItemRepository = catalogItemRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<CatalogItemViewModel>> GetCatalogItems()
        {
            var entities = await _catalogItemRepository.GetAllAsync();
            var catalogItems = entities.Select(item => new CatalogItemViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                PictureUrl = item.PictureUrl,
                Price = item.Price,
            }).ToList();

            return catalogItems;

        }

        public void UpdateCatalogItem(CatalogItemViewModel viewModel)
        {
            var existingCatalogItem = _catalogItemRepository.GetById(viewModel.Id);

            if (existingCatalogItem is null)
            {
                var exception = new Exception($"Catalog item {viewModel.Id} not found");
                _logger.LogError(exception, exception.Message);

                throw exception;
            }

            CatalogItem.CatalogItemDetails detail = new(viewModel.Name, viewModel.Price);
            existingCatalogItem.UpdateDetails(detail);

            _logger.LogInformation($"Updating catalog item {existingCatalogItem.Id}. " +
                $"Name {existingCatalogItem.Name}. " +
                $"Price {existingCatalogItem.Price}");

            _catalogItemRepository.Update(existingCatalogItem);

        }
    }
}
