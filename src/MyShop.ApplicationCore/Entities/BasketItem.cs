using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ApplicationCore.Entities
{
    public sealed class BasketItem
    {
        public int Id { get; set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public int CatalogItemId { get; private set; }
        public int BasketId { get; private set; }
        public BasketItem(int catalogItemId, int quantity, decimal unitPrice)
        {
            CatalogItemId = catalogItemId;
            UnitPrice = unitPrice;
            SetQuantity(quantity);
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }
    }
}
