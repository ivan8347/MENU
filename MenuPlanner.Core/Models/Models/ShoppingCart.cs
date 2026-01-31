using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuPlanner.Core.Models

{
    public class ShoppingCart
        {
            public List<IngredientItem> Items { get; set; } = new List<IngredientItem>();

            public void AddIngredients(IEnumerable<IngredientItem> ingredients)
            {
                Items.AddRange(ingredients);
            }

            public void Clear() => Items.Clear();

            public double TotalPrice => Items.Sum(i => i.TotalPrice);
        }
    }


