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

        public string Video { get; set; }

        public string Instruction { get; set; }

        public bool CanBeFrozen { get; set; }

        public List<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
    }
}



