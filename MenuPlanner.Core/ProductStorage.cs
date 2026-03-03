using System.Collections.Generic;
using System.IO;
using MenuPlanner.Core.Models;
using Newtonsoft.Json;

public static class ProductStorage
{
    private static string filePath = "products.json";

    public static List<Product> Load()
    {
        if (!File.Exists(filePath))
        {
            var emptyList = new List<Product>();
            Save(emptyList);
            return emptyList;
        }

        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Product>>(json);
    }

    public static void Save(List<Product> products)
    {
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}
