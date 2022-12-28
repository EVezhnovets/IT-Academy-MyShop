using MyShop.ApplicationCore.Entities;
using MyShop.Interfaces;
using MyShop.Models;

namespace MyShop.Services
{
    public class LocalCatalogItemRepository : IRepository<CatalogItem>
    {
        private static List<CatalogItem> _catalogItems = new List<CatalogItem>
            {
                new(1, ".NET Bot Black Sweatshirt", ".NET Bot Black Sweatshirt", 19.5M,  "/images/products/1.png"),
                new(2, ".NET Black & White Mug", ".NET Black & White Mug", 8.50M, "/images/products/2.png"),
                new(3,"Prism White T-Shirt", "Prism White T-Shirt", 12,  "/images/products/3.png"),
                new(4,".NET Foundation Sweatshirt", ".NET Foundation Sweatshirt", 12, "/images/products/4.png"),
                new(5,"Roslyn Red Sheet", "Roslyn Red Sheet", 8.5M, "/images/products/5.png"),
                new(6,".NET Blue Sweatshirt", ".NET Blue Sweatshirt", 12, "/images/products/6.png"),
                new(7,"Roslyn Red T-Shirt", "Roslyn Red T-Shirt",  12, "/images/products/7.png"),
                new(8,"Kudu Purple Sweatshirt", "Kudu Purple Sweatshirt", 8.5M, "/images/products/8.png"),
                new(9, "Cup<T> White Mug", "Cup<T> White Mug", 12, "/images/products/9.png"),
                new(10,".NET Foundation Sheet", ".NET Foundation Sheet", 12, "/images/products/10.png"),
                new(11,"Cup<T> Sheet", "Cup<T> Sheet", 8.5M, "/images/products/11.png"),
                new(12,"Prism White TShirt", "Prism White TShirt", 12, "/images/products/12.png")
            };

        public LocalCatalogItemRepository()
        {

        }
        public List<CatalogItem> GetAll()
        {
            return _catalogItems;
        }

        public CatalogItem? GetById(int id)
        {
            var item = _catalogItems.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public void Update(CatalogItem entity)
        {
            var existingItem = GetById(entity.Id);
            if (existingItem != null)
            {
                int index = _catalogItems.IndexOf(existingItem);
                _catalogItems[index] = entity;
            }
        }
    }
}
