// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Code Executed Sucessfully");

using FastFoodShop_.Shops;
using FastFoodShop_;

class Program
{
    static void Main(string[] args)
    {

         if (args.Length > 0)
         {
             Console.WriteLine( "args passed" );
         }
         Client customer = new(new VegFastFoodShop());
         Client foodie = new(new NonVegFastFoodShop());
         foodie.FoodDescription();
         customer.FoodDescription();
         Console.WriteLine($"Foodie : {foodie.FoodDescription()}");
         Console.WriteLine($"Customer : {customer.FoodDescription()}");
    }
}
