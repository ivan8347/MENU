using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MenuPlanner.Core;
using MenuPlanner.Core.Models;

namespace MENU
{
    public partial class FormMain : Form
    {
        // Список для отображения (категории + рецепты)
        private List<object> _groupedList = new List<object>();

        // Хранит список свернутых категорий
        private HashSet<string> _collapsedCategories = new HashSet<string>();

        public FormMain()
        {
            InitializeComponent();

            // Включаем ручное рисование элементов
            lstRecipes.DrawMode = DrawMode.OwnerDrawFixed;
            lstRecipes.DrawItem += lstRecipes_DrawItem;
            lstRecipes.MouseClick += lstRecipes_MouseClick;

            RefreshRecipeList();
        }

        // -----------------------------
        // ГРУППИРОВКА РЕЦЕПТОВ ПО КАТЕГОРИЯМ
        // -----------------------------
        private void RefreshRecipeList()
        {
            _groupedList.Clear();

            var groups = MenuService.Instance.Recipes
                .GroupBy(r => r.Category)
                .OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                string header = $"[{group.Key}]";
                _groupedList.Add(header);

                // Если категория свернута — рецепты не добавляем
                if (_collapsedCategories.Contains(header))
                    continue;

                foreach (var recipe in group)
                    _groupedList.Add(recipe);
            }

            lstRecipes.DataSource = null;
            lstRecipes.DataSource = _groupedList;
        }

        // -----------------------------
        // РИСОВАНИЕ ЭЛЕМЕНТОВ СПИСКА
        // -----------------------------
        private void lstRecipes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            var item = _groupedList[e.Index];

            // Заголовок категории
            if (item is string categoryHeader)
            {
                bool collapsed = _collapsedCategories.Contains(categoryHeader);
                string prefix = collapsed ? "► " : "▼ ";

                TextRenderer.DrawText(
                    e.Graphics,
                    prefix + categoryHeader,
                    new Font(e.Font, FontStyle.Bold),
                    e.Bounds,
                    Color.DarkBlue,
                    TextFormatFlags.Left
                );
            }
            // Рецепт
            else if (item is Recipe recipe)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "   " + recipe.Name,
                    e.Font,
                    e.Bounds,
                    Color.Black,
                    TextFormatFlags.Left
                );
            }

            e.DrawFocusRectangle();
        }

        // -----------------------------
        // КЛИК ПО КАТЕГОРИИ — СВЕРНУТЬ/РАЗВЕРНУТЬ
        // -----------------------------
        private void lstRecipes_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstRecipes.IndexFromPoint(e.Location);
            if (index < 0) return;

            var item = _groupedList[index];

            if (item is string categoryHeader)
            {
                if (_collapsedCategories.Contains(categoryHeader))
                    _collapsedCategories.Remove(categoryHeader);
                else
                    _collapsedCategories.Add(categoryHeader);

                RefreshRecipeList();
            }
        }

        // -----------------------------
        // ВЫБОР РЕЦЕПТА
        // -----------------------------
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe recipe)
            {
                lblTotalCalories.Text = $"Калорийность: {recipe.TotalCalories:F2} кКал";
                lblTotalBreadUnits.Text = $"ХЕ: {recipe.TotalBreadUnits:F2} ед.";
                lblTotalPrice.Text = $"Стоимость: {recipe.TotalPrice:F2} руб.";

                UpdateColorIndicators(recipe);
            }
        }

        private void UpdateColorIndicators(Recipe recipe)
        {
            // Калории
            lblTotalCalories.ForeColor =
                recipe.TotalCalories > 1000 ? Color.Red :
                recipe.TotalCalories > 500 ? Color.DarkOrange :
                Color.DarkGreen;

            // ХЕ
            lblTotalBreadUnits.ForeColor =
                recipe.TotalBreadUnits > 5 ? Color.Red :
                recipe.TotalBreadUnits > 3 ? Color.DarkOrange :
                Color.DarkGreen;

            // Цена
            lblTotalPrice.ForeColor =
                recipe.TotalPrice > 300 ? Color.Red :
                recipe.TotalPrice > 150 ? Color.DarkOrange :
                Color.DarkGreen;
        }

        // -----------------------------
        // КНОПКИ
        // -----------------------------
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            var form = new RecipeForm();
            if (form.ShowDialog() == DialogResult.OK)
                RefreshRecipeList();
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe recipe)
            {
                var form = new RecipeForm(recipe);
                if (form.ShowDialog() == DialogResult.OK)
                    RefreshRecipeList();
            }
            else
            {
                MessageBox.Show("Выберите рецепт для редактирования.");
            }
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe recipe)
            {
                var result = MessageBox.Show(
                    $"Удалить рецепт <<{recipe.Name}>>?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MenuService.Instance.Recipes.Remove(recipe);
                    RefreshRecipeList();
                }
            }
            else
            {
                MessageBox.Show("Выберите рецепт для удаления.");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // поиск добавим позже
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            // корзину добавим позже
        }

        private void btnGenerateMenu_Click(object sender, EventArgs e)
        {
            // генерацию меню добавим позже
        }
        private void lblTotalBreadUnits_Click(object sender, EventArgs e)
        {
            // обработчик пока не нужен
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // обработчик пока не нужен
        }
       

    }
}
