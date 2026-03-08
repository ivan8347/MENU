using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Core.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public string Instruction { get; set; }
        public string Category { get; set; }
        public bool CanBeFrozen { get; set; }
        public string VideoPath { get; set; }

        public List<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();

        // Эти поля сохраняются в JSON
        public double TotalCalories { get; set; }
        public double TotalBreadUnits { get; set; }
        public double TotalPrice { get; set; }

        // Автопересчёт после загрузки
        public void Recalculate()
        {
            TotalCalories = Ingredients.Sum(i => i.Calories);
            TotalBreadUnits = Ingredients.Sum(i => i.BreadUnits);
            TotalPrice = Ingredients.Sum(i => i.PricePerUnit);

        }
    }
}


