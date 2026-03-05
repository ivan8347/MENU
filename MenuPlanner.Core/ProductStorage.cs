using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using MenuPlanner.Core.Models;

namespace MenuPlanner.Core
{
    public static class ProductStorage
    {
        private static readonly string FilePath = "products.json";

        // Загружает продукты из структурированного JSON
        public static List<Product> Load()
        {
            if (!File.Exists(FilePath))
                return new List<Product>();

            string json = File.ReadAllText(FilePath);

            // Загружаем JSON как словарь: категория → список продуктов
            var dict = JsonConvert.DeserializeObject<Dictionary<string, List<Product>>>(json);

            if (dict == null)
                return new List<Product>();

            // Собираем все продукты в один список
            return dict.Values.SelectMany(x => x).ToList();
        }

        // Добавляет продукт в файл (в категорию "Прочее")
        public static void AddProduct(Product product)
        {
            Dictionary<string, List<Product>> dict;

            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                dict = JsonConvert.DeserializeObject<Dictionary<string, List<Product>>>(json)
                       ?? new Dictionary<string, List<Product>>();
            }
            else
            {
                dict = new Dictionary<string, List<Product>>();
            }

            // Если нет категории "Прочее" — создаём
            if (!dict.ContainsKey("Прочее"))
                dict["Прочее"] = new List<Product>();

            // Добавляем продукт
            dict["Прочее"].Add(product);

            // Сохраняем обратно
            string output = JsonConvert.SerializeObject(dict, Formatting.Indented);
            File.WriteAllText(FilePath, output);
        }
    }
}
