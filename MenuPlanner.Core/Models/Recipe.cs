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


        public double TotalCalories
        {
            get
            {
                double sum = 0;
                foreach (var ing in Ingredients)
                    sum += ing.Calories;
                return sum;
            }
        }

        public double TotalBreadUnits
        {
            get
            {
                double sum = 0;
                foreach (var ing in Ingredients)
                    sum += ing.BreadUnits;
                return sum;
            }
        }

        public double TotalPrice
        {
            get
            {
                double sum = 0;
                foreach (var ing in Ingredients)
                    sum += ing.PricePerUnit * ing.Quantity;
                return sum;
            }
        }

    }
}
