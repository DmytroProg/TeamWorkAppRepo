using NetworkApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetworkApp5.Services
{
    public class ProductService
    {
        private readonly string _filePath;

        public ProductService(string filePath)
        {
            _filePath = filePath;
        }

        public void Init()
        {
            var products = new List<Product>
            {
                new Product { Name = "Хліб", Price = 20.5f, Quantity = 10 },
                new Product { Name = "Молоко", Price = 35.0f, Quantity = 5 },
                new Product { Name = "Яблука", Price = 50.0f, Quantity = 8 }
            };

            SaveProducts(products);

            var loaded = LoadProducts();

            foreach (var p in loaded)
                Console.WriteLine(p);
        }

        public void SaveProducts(List<Product> products)
        {
            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { PropertyNameCaseInsensitive = false });
            File.WriteAllText(_filePath, json);
        }

        public List<Product> LoadProducts()
        {
            if (!File.Exists(_filePath))
                return new List<Product>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }
        
    }
}