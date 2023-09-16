using FastFoodShop.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Client customer = new Client(new VegFastFoodShop());
            Client foodie = new Client(new NonVegFastFood());
        }
    }
}
