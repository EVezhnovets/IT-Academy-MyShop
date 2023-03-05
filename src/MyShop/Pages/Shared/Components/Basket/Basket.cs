using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyShop.Infrastructure.Identity;
using MyShop.Interfaces;
using MyShop.Models;

namespace MyShop.Pages.Shared.Components.BasketComponent
{
    public sealed class Basket : ViewComponent
    {
        private readonly IBasketViewModelService _basketService;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public Basket(IBasketViewModelService basketService, SignInManager<ApplicationUser> signInManager)
        {
            _basketService = basketService;
            _signInManager = signInManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vm = new BasketComponentViewModel { ItemsCount = 5 };

            return View(vm);
        } 
    }
}
