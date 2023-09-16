using FastFoodShop_.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodShop_
{
   
    class Client
    {
        private readonly Burger _burger;
        private readonly Momos _momos;
        private readonly Sandwich _sandiwch;

        public Client(FastFoodShop shop)
        {
            _burger = shop.CreateBurger();
            _momos = shop.CreateMomos();
            _sandiwch = shop.CreateSandwich();
        }

        public string FoodDescription()
        {
            return $"Today, I am going to eat {_burger.GetType().Name}, {_momos.GetType().Name} and {_sandiwch.GetType().Name}";
        }
    }
}
