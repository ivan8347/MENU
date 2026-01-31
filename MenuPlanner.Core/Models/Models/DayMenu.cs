using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Core.Models

{
    public class DayMenu
    {
        public string Day { get; set; }
        public Recipe Dish {  get; set; }
        public bool FromFreezer { get; set; }


    }
}
