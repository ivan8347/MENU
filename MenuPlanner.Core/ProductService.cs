using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using MenuPlanner.Core.Models;

namespace MenuPlanner.Core
{
    public class ProductService
    {
        public static ProductService Instance { get; } = new ProductService();

        public List<Product> Products { get; private set; } = new List<Product>();

        private ProductService()
        {
            LoadDefaultProducts();
        }

        private void LoadDefaultProducts()
        {
            Products.Add(new Product
            {
                Name = "Мука",
                Unit = "г",
                CaloriesPerUnit = 3.64,
                BreadUnitsPerUnit = 0.007,
                PricePerUnit = 20,
                Store = "Ашан"
            });

            Products.Add(new Product
            {
                Name = "Яйцо",
                Unit = "шт",
                CaloriesPerUnit = 70,
                BreadUnitsPerUnit = 0.5,
                PricePerUnit = 10,
                Store = "Глобус"
            });

            // сюда можно добавлять новые продукты
        }
    }
}
