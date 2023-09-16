// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Code Executed Sucessfully");

using FastFoodShop_.Shops;
using FastFoodShop_;

class Program
{
    static void Main(string[] args)
    {
        Client customer = new Client(new VegFastFoodShop());
        Client foodie = new Client(new NonVegFastFoodShop());
        foodie.FoodDescription();
        Console.WriteLine($"Foodie : {foodie.FoodDescription()}");
    }
}
