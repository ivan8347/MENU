using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Core.Models
{
    public class RecipeIngredient
    {
        public string Name { get; set; }

        public double Quantity { get; set; }

        public string Unit { get; set; }
        public double PricePerUnit { get; set; }

        public string Store { get; set; }
        public double Calories { get; set; }

        public double BreadUnits { get; set; }
    }
}


