using MyShop.ApplicationCore.Entities;
using MyShop.Interfaces;
using MyShop.Pages.Basket;

namespace MyShop.Services
{
    public sealed class BasketViewModelService : IBasketViewModelService
    {
        public Task<int> CountTotalBasketItems(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<BasketViewModel> GetOrCreateBasketForUser(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<BasketViewModel> Map(Basket basket)
        {
            throw new NotImplementedException();
        }
    }
}
