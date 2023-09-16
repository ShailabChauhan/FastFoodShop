# FastFoodShop
FastFoodShop is a C# project that demonstrates the implementation of the abstract factory design pattern in the context of a fast food shop. It provides a structured and object-oriented approach to managing and creating different types of fast food products.

# Overview
Fast food establishments often offer a variety of menu items, including both non-vegetarian and vegetarian options. To maintain a clean and extensible codebase, this project employs the abstract factory design pattern.

# Key Components
Abstract Factory (FastFoodShop): This class serves as the abstract factory and defines the methods for creating various fast food products, such as burgers, momos, and sandwiches.

Concrete Factories (NonVegFastFoodShop and VegFastFoodShop): These classes implement the abstract factory interface and are responsible for creating specific types of non-vegetarian and vegetarian fast food products.

Abstract Products (Burger, Momos, Sandwich): These abstract classes define the common interface for all fast food products.

Concrete Products (ChickenBurger, VegBurger, ChickenMomos, VegMomos, ChickenSandwich, VegSandwich): These classes implement the abstract product interfaces and represent the actual fast food items.

# Features
Demonstrates the abstract factory design pattern for creating fast food products.

Provides a clean and extensible architecture for managing different types of fast food items.

Includes unit tests to ensure the correctness of the product creation process.
# Flow Design

![WhatsApp Image 2023-09-16 at 4 11 46 PM](https://github.com/ShailabChauhan/FastFoodShop/assets/98279939/b4689c5b-c96b-400c-bbc6-e35583034b6e)
