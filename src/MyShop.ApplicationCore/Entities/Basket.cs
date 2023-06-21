using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ApplicationCore.Entities
{
    public sealed class Basket
    {
        private readonly List<BasketItem> _items = new List<BasketItem>();
        public int Id { get; set; }
        public string? BuyerId { get; set; }
        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();
        public Basket()
        {

        }
        public Basket(string userName)
        {
            BuyerId = userName;
        }
        public void AddItem(int catalogItemId, decimal unitPrice, int quantity = 1)
        {
            if (!Items.Any(i => i.CatalogItemId == catalogItemId))
            {
                _items.Add(new BasketItem(catalogItemId, quantity, unitPrice));
                return;
            }
            var existingItem = Items.First(i => i.CatalogItemId == catalogItemId);
            existingItem.AddQuantity(quantity);
        }

    }
}
