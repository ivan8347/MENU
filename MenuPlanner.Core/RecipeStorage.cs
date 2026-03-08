using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MenuPlanner.Core.Models
{
    public class RecipeStorage
    {
        private readonly string _filePath = "recipes.json";

        public List<Recipe> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Recipe>();

            var json = File.ReadAllText(_filePath);

            var recipes = JsonConvert.DeserializeObject<List<Recipe>>(json)
                          ?? new List<Recipe>();

            // Автопересчёт после загрузки
            foreach (var r in recipes)
                r.Recalculate();

            return recipes;
        }

        public void Save(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes, Formatting.Indented);

            File.WriteAllText(_filePath, json);
        }
    }
}
