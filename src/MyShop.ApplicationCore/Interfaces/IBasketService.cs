using MyShop.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ApplicationCore.Interfaces
{
    public interface IBasketService
    {
        Task<Basket> AddItem2Basket(string userName, int catalogItemId, decimal price, int quantity = 1);
    }
}
