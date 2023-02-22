using MyShop.ApplicationCore.Entities;
using MyShop.ApplicationCore.Interfaces;

namespace MyShop.ApplicationCore.Services
{
    public sealed class BasketService : IBasketService
    {
        private readonly IRepository<Basket> _basketRepository;
        public BasketService(IRepository<Basket> basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public async Task<Basket> AddItem2Basket(string userName, int catalogItemId, decimal price, int quantity = 1)
        {
            var basket = await _basketRepository.FirstOrDefaultAsync(b => b.BuyerId == userName);

            if (basket == null)
            {
                basket = new Basket(userName);
                basket = await _basketRepository.AddAsync(basket);
            }

            basket.AddItem(catalogItemId, price, quantity);
            await _basketRepository.UpdateAsync(basket);


            return basket;
        }
    }
}
