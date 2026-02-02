using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuPlanner.Core.Models;



using System.Collections.Generic;
using MenuPlanner.Core.Models;

namespace MenuPlanner.Core
{
    public class MenuService
    {
        // Singleton
        public static MenuService Instance { get; } = new MenuService();

        // Хранилище рецептов
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        // Приватный конструктор — чтобы нельзя было создать второй экземпляр
        private MenuService() { }
    }
}



