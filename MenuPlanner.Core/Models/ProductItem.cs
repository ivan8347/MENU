using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Core.Models

{
    public class ProductItem
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double PricePerUnit { get; set; }
        public string Store { get; set; }
        public double CaloriesPerUnit { get; set; }
        public double MinThreshold { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsFrozen { get; set; }
        public double TotalPrice => Quantity * PricePerUnit;
        public double TotalCalories => Quantity * CaloriesPerUnit;
        public override string ToString() =>
            $"{Name} {Quantity} {Unit}";
    }
}
