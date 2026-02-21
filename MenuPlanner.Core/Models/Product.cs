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
        public string Unit { get; set; }                 // г, мл, шт, ложки, стаканы
        public double CaloriesPerUnit { get; set; }
        public double BreadUnitsPerUnit { get; set; }
        public double PricePerUnit { get; set; }
        public string Store { get; set; }

        public double ConvertToBaseUnit(double qty)
        {
            if (Unit == "ч.л")
                return qty * 5;      // 5 мл

            if (Unit == "ст.л")
                return qty * 15;     // 15 мл

            if (Unit == "ст")
                return qty * 200;    // 200 мл

            return qty;              // г, мл, шт — без изменений
        }


        public override string ToString() => Name;
    }

}


