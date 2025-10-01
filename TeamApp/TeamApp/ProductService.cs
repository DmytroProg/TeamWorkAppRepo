using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TeamApp
{
    public class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Cost} UAH";
        }
    }

    public static class ProductService
    {
        private static string _dbPath = "";
        public static async Task ProductMainEntryAsync(string dbPath)
        {
            _dbPath = dbPath;

            Product product_1 = new Product();
            product_1.Name = "iPhone 17 Pro Max";
            product_1.Cost = 72000;

            Product product_2 = new Product();
            product_2.Name = "iPhone 16 Pro Max";
            product_2.Cost = 62000;

            Product product_3 = new Product();
            product_3.Name = "iPhone 15 Pro Max";
            product_3.Cost = 52000;

            await WriteProductAsync(product_1);
            await WriteProductAsync(product_2);
            await WriteProductAsync(product_3);

            await ReadAllProductsAsync();
        }

        public static async Task<List<Product>> LoadProducts()
        {
            List<Product> products;
            try
            {
                string content = await File.ReadAllTextAsync(_dbPath);
                products = JsonSerializer.Deserialize<List<Product>>(content ?? "[]");
            }
            catch (Exception ex)
            {
                products = new List<Product>();
            }

            return products;
        }

        public static async Task ReadAllProductsAsync()
        {
            List<Product> products = await LoadProducts();

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        public static async Task WriteProductAsync(Product product)
        {
            string content = await File.ReadAllTextAsync(_dbPath);
            List<Product> products = await LoadProducts();
            products.Add(product);

            string json = JsonSerializer.Serialize<List<Product>>(products);
            await File.WriteAllTextAsync(_dbPath, json);
        }
    }
}
