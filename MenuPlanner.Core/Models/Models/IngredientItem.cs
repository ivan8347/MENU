using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Core.Models

{
    public class IngredientItem
    {
        public string Name { get; set; }          // Название ингредиента
        public double Quantity { get; set; }      // Количество
        public string Unit { get; set; }          // Единица измерения (г, кг, мл, шт)

        public double CaloriesPerUnit { get; set; }   // Калорийность на 1 единицу
        public double PricePerUnit { get; set; }      // Цена за 1 единицу

        public double TotalCalories => Quantity * CaloriesPerUnit;
        public double TotalPrice => Quantity * PricePerUnit;
        public string Store { get; set; }   // В каком магазине куплено

        public override string ToString() =>
            $"{Name} {Quantity}{Unit}";
    }
}

