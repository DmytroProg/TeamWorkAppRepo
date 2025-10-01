using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TeamApp.Models;

namespace TeamApp
{
    public class ProductManager
    {
        private readonly string _filePath;

        public ProductManager(string filePath)
        {
            _filePath = filePath;
        }

        public void SaveProduct(Product product)
        {
            List<Product> products = LoadProducts();
            products.Add(product);

            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
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
