using MyShop.ApplicationCore.Entities;
using MyShop.Pages.Basket;

namespace MyShop.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
        Task<int> CountTotalBasketItems(string userName);
        Task<BasketViewModel> Map(Basket basket);
    }
}
