using System;
using System.Collections.Generic;

namespace Laboratory2{
    public class ProductDatabase
    {
        // Class for managing the product database
        private static ProductDatabase instance;
        private List<Product> products;

        private ProductDatabase()
        {
            products = new List<Product>();
        }

        public static ProductDatabase GetInstance()
        {
            if (instance == null)
            {
                instance = new ProductDatabase();
            }
            return instance;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
        }
    }
}