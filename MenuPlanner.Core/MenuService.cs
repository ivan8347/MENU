using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuPlanner.Core.Models;



namespace MenuPlanner.Core
    {
        public class MenuService
        {
            public List<Recipe> Recipes { get; set; } = new List<Recipe>();
            public List<DayMenu> WeekMenu { get; private set; } = new List<DayMenu>();
            public ShoppingCart Cart { get; private set; } = new ShoppingCart();

            private readonly string[] _days =
            {
            "Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"
        };

            public void GenerateMenu()
            {
                WeekMenu.Clear();
                var rnd = new Random();

                foreach (var day in _days)
                {
                    if (Recipes.Count == 0)
                        break;

                    var recipe = Recipes[rnd.Next(Recipes.Count)];
                    bool freezerDay = (day == "Суббота" || day == "Воскресенье");

                    WeekMenu.Add(new DayMenu
                    {
                        Day = day,
                        Dish = recipe,
                        FromFreezer = freezerDay && recipe.Freezable
                    });
                }

                BuildCart();
            }

            private void BuildCart()
            {
                Cart.Clear();
                foreach (var day in WeekMenu)
                    Cart.AddIngredients(day.Dish.Ingredients);
            }

            public List<Recipe> Search(string query)
            {
                query = query.ToLower();

                return Recipes
                    .Where(r =>
                        r.Name.ToLower().Contains(query) ||
                        r.Ingredients.Any(i => i.Name.ToLower().Contains(query)) ||
                        r.Instructions.ToLower().Contains(query))
                    .ToList();
            }
        }
    }


