using System;
using System.Drawing;
using System.Windows.Forms;
using MenuPlanner.Core;
using MenuPlanner.Core.Models;

namespace MENU
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            RefreshRecipeList();
        }

        // Обновление списка рецептов
        private void RefreshRecipeList()
        {
            lstRecipes.DataSource = null;
            lstRecipes.DataSource = MenuService.Instance.Recipes;
            lstRecipes_SelectedIndexChanged(null, null);

        }

        // Добавить рецепт
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            var form = new RecipeForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshRecipeList();
            }
        }

        // Редактировать рецепт
        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe recipe)
            {
                var form = new RecipeForm(recipe);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshRecipeList();
                }
            }
            else
            {
                MessageBox.Show("Выберите рецепт для редактирования.");
            }
        }
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe recipe)
            {
                lblTotalCalories.Text = $"Калорийность: {recipe.TotalCalories:F2}";
                lblTotalBreadUnits.Text = $"ХЕ: {recipe.TotalBreadUnits:F2} ед.";
                lblTotalPrice.Text = $"Стоимость: {recipe.TotalPrice:F2} руб.";
                UpdateColorIndicators(recipe);
            }
            else
            {
                lblTotalCalories.Text = "Калорийность: 0";
                lblTotalBreadUnits.Text = "ХЕ: 0 ед.";
                lblTotalPrice.Text = "Стоимость: 0 руб.";

                lblTotalCalories.ForeColor = Color.Black; 
                lblTotalBreadUnits.ForeColor = Color.Black;
                lblTotalPrice.ForeColor = Color.Black;
            }
        }
        private void UpdateColorIndicators(Recipe recipe)
        {
            // Калории
            if (recipe.TotalCalories > 1000)
                lblTotalCalories.ForeColor = Color.Red;
            else if (recipe.TotalCalories > 500)
                lblTotalCalories.ForeColor = Color.DarkOrange;
            else
                lblTotalCalories.ForeColor = Color.DarkGreen;

            // ХЕ
            if (recipe.TotalBreadUnits > 5)
                lblTotalBreadUnits.ForeColor = Color.Red;
            else if (recipe.TotalBreadUnits > 3)
                lblTotalBreadUnits.ForeColor = Color.DarkOrange;
            else
                lblTotalBreadUnits.ForeColor = Color.DarkGreen;

            // Стоимость
            if (recipe.TotalPrice > 300)
                lblTotalPrice.ForeColor = Color.Red;
            else if (recipe.TotalPrice > 150)
                lblTotalPrice.ForeColor = Color.DarkOrange;
            else
                lblTotalPrice.ForeColor = Color.DarkGreen;
        }


        private void btnGenerateMenu_Click(object sender, EventArgs e)
        {
            // позже добавим
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // позже добавим
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            // позже добавим
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe recipe)
            {
                var result = MessageBox.Show($"Удалить рецепт <<{recipe.Name}>>?",
                   "Подтвеждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MenuService.Instance.Recipes.Remove(recipe);
                    RefreshRecipeList();
                }
            }
            else { MessageBox.Show("Выберети рецепт для удаления"); }
        }
    }
}
