using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.ApplicationCore.Entities
{
    public sealed class Basket
    {
        public int Id { get; set; }
        public string? BuyerId { get; set; }
        public Basket()
        {

        }
        public Basket(string userName)
        {
            BuyerId = userName;
        }
    }
}
