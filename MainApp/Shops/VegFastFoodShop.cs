using FastFoodShop_.Abstract_Product;
using FastFoodShop_.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodShop_.Shops
{
    public class VegFastFoodShop  : FastFoodShop
    {
        public override Burger CreateBurger()
        {
            return new VegBurger();
        }

        public override Momos CreateMomos()
        {
            return new VegMomos();
        }

        public override Sandwich CreateSandwich()
        {
            return new VegSandwich();
        }
    }
}
