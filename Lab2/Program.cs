﻿using System;

namespace Laboratory2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Singleton
            ProductDatabase database = ProductDatabase.GetInstance();

            // Using Factory Method
            IProductFactory factory = new ConcreteProductFactory();
            Product product1 = factory.CreateProduct("Laptop", 1000.0);
            Product product2 = factory.CreateProduct("Phone", 500.0);

            // Using Builder
            Product product3 = new ProductBuilder()
                .WithName("Tablet")
                .WithPrice(300.0)
                .Build();

            // Using Prototype
            Product clonedProduct = (Product)product1.Clone();

            // Adding products to the database
            database.AddProduct(product1);
            database.AddProduct(product2);
            database.AddProduct(product3);

            // Displaying products
            database.DisplayProducts();
        }
    }
}
