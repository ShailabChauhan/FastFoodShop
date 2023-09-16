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
            //throw new NotImplementedException();
            return new VegBurger();
        }

        public override Momos CreateMomos()
        {
           // throw new NotImplementedException();
            return new VegMomos();
        }

        public override Sandwich CreateSandwich()
        {
           // throw new NotImplementedException();
            return new VegSandwich();
        }
    }
}
