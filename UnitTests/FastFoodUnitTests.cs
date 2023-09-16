using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastFoodShop_.Products;
using FastFoodShop_.Shops;
using FastFoodShop_.Abstract_Product;
using System;
using FastFoodShop_;

namespace UnitTests
{
    [TestClass]
    public class FastFoodShopTests
    {
        [TestMethod]
        public void TestNonVegFastFoodCreation()
        {
          

            // Arrange
            FastFoodShop nonVegFastFoodShop = new NonVegFastFood();

            // Act
            Burger burger = nonVegFastFoodShop.CreateBurger();
            Momos momos = nonVegFastFoodShop.CreateMomos();
            Sandwich sandwich = nonVegFastFoodShop.CreateSandwich();

            // Assert
            Assert.IsInstanceOfType(burger, typeof(ChickenBurger));
            Assert.IsInstanceOfType(momos, typeof(ChickenMomos));
            Assert.IsInstanceOfType(sandwich, typeof(ChickenSandwich));
        }


        public void TestVegFastFoodShopCreation()
        {
            // Arrange
            FastFoodShop vegFastFoodShop = new VegFastFoodShop();

            // Act
            Burger burger = vegFastFoodShop.CreateBurger();
            Momos momos = vegFastFoodShop.CreateMomos();
            Sandwich sandwich = vegFastFoodShop.CreateSandwich();

            // Assert
            Assert.IsInstanceOfType(burger, typeof(VegBurger));
            Assert.IsInstanceOfType(momos, typeof(VegMomos));
            Assert.IsInstanceOfType(sandwich, typeof(VegSandwich));
        }


    }
}
