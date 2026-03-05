using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MenuPlanner.Core;
using MenuPlanner.Core.Models;

namespace MENU
{
    public class ProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            _products = ProductStorage.Load();
        }

        public List<Product> GetAll() => _products;

        public Product Find(string name)
        {
            return _products.FirstOrDefault(
                p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Product EnsureExists(string name)
        {
            var product = Find(name);
            if (product != null)
                return product;

            var ask = MessageBox.Show(
                $"Продукт \"{name}\" не найден. Добавить вручную?",
                "Новый продукт",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ask == DialogResult.No)
                return null;

            string caloriesStr = Microsoft.VisualBasic.Interaction.InputBox(
                $"Введите калорийность (кКал на 100 г) для \"{name}\":",
                "Новый продукт");

            string buStr = Microsoft.VisualBasic.Interaction.InputBox(
                $"Введите ХЕ (на 100 г) для \"{name}\":",
                "Новый продукт");

            if (!double.TryParse(caloriesStr, out double calories) ||
                !double.TryParse(buStr, out double bu))
            {
                MessageBox.Show("Ошибка: неверный формат чисел.");
                return null;
            }

            product = new Product
            {
                Name = name,
                CaloriesPerUnit = calories,
                BreadUnitsPerUnit = bu
            };

            ProductStorage.AddProduct(product);
            _products = ProductStorage.Load();

            return product;
        }

    }
}