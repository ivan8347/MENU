using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MenuPlanner.Core.Models;

namespace MenuPlanner.Core
{
    public static class ProductStorage
    {
        private static readonly string FilePath = "products.json";

        public static List<Product> Load()
        {
            if (!File.Exists(FilePath))
                return new List<Product>();

            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Product>>(json)
                   ?? new List<Product>();
        }

        public static void Save(List<Product> products)
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static void AddProduct(Product product)
        {
            var products = Load();
            products.Add(product);
            Save(products);
        }
    }
}