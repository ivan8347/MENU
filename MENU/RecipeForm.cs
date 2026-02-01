using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuPlanner.Core.Models;
using MenuPlanner.Core;

namespace MENU
{
    public partial class RecipeForm : Form
    {
        public RecipeForm()
        {
            InitializeComponent();
        }
        

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {

            dgvIngredients.Rows.Add
            (
                txtIngName.Text,
                txtIngQty.Text,
                txtIngUnit.Text,
                txtIngCalories.Text,
                txtPrice.Text,
                txtIngBreadUnits.Text,
                cmbStore.SelectedItem?.ToString()
            );

                 txtIngName.Clear();
                 txtIngQty.Clear();
                 txtIngUnit.Clear();
                 txtIngCalories.Clear();
                 txtPrice.Clear();
                 cmbStore.SelectedIndex = -1;
        }



        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count > 0)
            {
                dgvIngredients.Rows.RemoveAt(dgvIngredients.SelectedRows[0].Index);
            }
        }
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = dlg.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var recipe = new Recipe
            {
                Name = txtRecipeName.Text,
                Instructions = txtInstructions.Text,
                Freezable = chkFreezable.Checked,
                ImagePath = txtImagePath.Text,
                VideoLink = txtVideo.Text,
                Ingredients = new List<IngredientItem>()
            };

            foreach (DataGridViewRow row in dgvIngredients.Rows)
            {
                if (row.IsNewRow) continue;

                recipe.Ingredients.Add(new IngredientItem
                {
                    Name = row.Cells["colName"].Value?.ToString(),
                    Quantity = double.Parse(row.Cells["colQty"].Value?.ToString()),
                    Unit = row.Cells["colUnit"].Value?.ToString(),
                    CaloriesPerUnit = double.Parse(row.Cells["colCalories"].Value?.ToString()),
                    PricePerUnit = double.Parse(row.Cells["colPrice"].Value?.ToString()),
                    BreadUnitsPerUnit = double.Parse(row.Cells["colBreadUnits"].Value?.ToString()),

                    Store = row.Cells["colStore"].Value?.ToString()
                });
            }

            // Добавляем рецепт в сервис
            MenuService.Instance.Recipes.Add(recipe);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        

        private void txtInstructoins_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            cmbStore.Items.AddRange(new string[]
            {
                 "Глобус",
                 "Пятёрочка",
                 "Магнит",
                 "ВкусВилл",
                 "Ашан",
                 "Лента",
                 "FixPrice"
            });
        }

        

        private void txtVideoLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
