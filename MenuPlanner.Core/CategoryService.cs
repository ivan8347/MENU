using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Core
{

    public class CategoryService
    {
        public static CategoryService Instance { get; } = new CategoryService();

        public List<string> Categories { get; private set; } = new List<string>();

        private CategoryService()
        {
            LoadDefaultCategories();
        }

        private void LoadDefaultCategories()
        {
            Categories.Add("Завтраки");
            Categories.Add("Супы");
            Categories.Add("Горячее");
            Categories.Add("Гарниры");
            Categories.Add("Салаты");
            Categories.Add("Десерты");
            Categories.Add("Напитки");
        }
    }


}
