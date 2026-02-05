using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Core.Models
{
   
        public class Product
        {
            public string Name { get; set; }
            public string Unit { get; set; }                 // г, мл, шт
            public double CaloriesPerUnit { get; set; }      // калорий на 1 единицу
            public double BreadUnitsPerUnit { get; set; }    // ХЕ на 1 единицу
            public double PricePerUnit { get; set; }         // цена за 1 единицу
            public string Store { get; set; }                // магазин

            public override string ToString() => Name;
        }
    }


