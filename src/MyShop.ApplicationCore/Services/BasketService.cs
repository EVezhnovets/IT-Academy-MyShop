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

        public async Task<Basket> AddItem2Basket(string userName)
        {
            //TODO check if basket exist for this user
            Basket basket = default;

            if (basket == null)
            {
                basket = new Basket(userName);
                basket = await _basketRepository.AddAsync(basket);
            }
            return basket;
        }
    }
}
