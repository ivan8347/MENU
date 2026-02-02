using System;
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
    }
}
