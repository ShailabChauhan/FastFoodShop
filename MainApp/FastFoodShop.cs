using FastFoodShop_.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodShop_
{
    public abstract class FastFoodShop
    {
        public abstract Burger CreateBurger();
        public abstract Momos CreateMomos();
        public abstract Sandwich CreateSandwich();

    }
}
