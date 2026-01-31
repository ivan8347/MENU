using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        using System.Collections.Generic;
using System.Linq;

namespace MenuPlanner.Core.Models

{

    public class Recipe
        {
            public string Name { get; set; }
            public List<IngredientItem> Ingredients { get; set; } = new List<IngredientItem>();
            public string Instructions { get; set; }
            public bool Freezable { get; set; }
            public string ImagePath { get; set; }
            public string VideoLink { get; set; }

            public double TotalCalories => Ingredients.Sum(i => i.TotalCalories);
            public double TotalPrice => Ingredients.Sum(i => i.TotalPrice);

            public override string ToString() => Name;
        }
    }


