using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MenuPlanner.Core.Models;
using MenuPlanner.Core;
using System.Xml.Linq;



namespace MENU
{
    public partial class RecipeForm : Form
    {
        private Recipe _recipeToEdit;
        private string _photoPath;

        // Локальный класс продукта (если пока нет ProductService)
        private class Product
        {
            public string Name { get; set; }
            public string Unit { get; set; }
            public double CaloriesPerUnit { get; set; }
            public double BreadUnitsPerUnit { get; set; }
            public double PricePerUnit { get; set; }
            public string Store { get; set; }

            public override string ToString() => Name;
        }

        private List<Product> products = new List<Product>();


        public RecipeForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        public RecipeForm(Recipe recipe)
        {
            InitializeComponent();
            LoadProducts();
            _recipeToEdit = recipe;
            LoadRecipeData();
        }
        private void LoadProducts()
        {
            products.Add(new Product
            {
                Name = "Мука",
                Unit = "г",
                CaloriesPerUnit = 3.64,
                BreadUnitsPerUnit = 0.007,
                PricePerUnit = 20,
                Store = "Ашан"
            });

            products.Add(new Product
            {
                Name = "Яйцо",
                Unit = "шт",
                CaloriesPerUnit = 70,
                BreadUnitsPerUnit = 0.5,
                PricePerUnit = 10,
                Store = "Глобус"
            });

            cmbProductName.DataSource = products;
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductName.SelectedItem is Product product)
            {
                txtUnit.Text = product.Unit;
                txtPrice.Text = product.PricePerUnit.ToString();
                cmbStore.SelectedItem = product.Store;
            }
        }
        private void LoadRecipeData()
        {
            txtName.Text = _recipeToEdit.Name;
            txtInstruction.Text = _recipeToEdit.Instruction;
            chkCanBeFrozen.Checked = _recipeToEdit.CanBeFrozen;

            if (!string.IsNullOrEmpty(_recipeToEdit.PhotoPath) && File.Exists(_recipeToEdit.PhotoPath))
            {
                picPhoto.Image = Image.FromFile(_recipeToEdit.PhotoPath);
                _photoPath = _recipeToEdit.PhotoPath;
            }

            txtVideo.Text = _recipeToEdit.VideoPath;

            dgvIngredients.Rows.Clear();

            foreach (var ing in _recipeToEdit.Ingredients)
            {
                dgvIngredients.Rows.Add(
                    ing.Name,
                    ing.Quantity,
                    ing.Unit,
                    ing.Calories,
                    ing.BreadUnits,
                    ing.PricePerUnit,
                    ing.Store
                );
            }
        }



        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (cmbProductName.SelectedItem == null)
            {
                MessageBox.Show("Выберите продукт.");
                return;
            }

            var product = (Product)cmbProductName.SelectedItem;
            double qty = (double)nudQuantity.Value;

            double totalCalories = product.CaloriesPerUnit * qty;
            double totalBreadUnits = product.BreadUnitsPerUnit * qty;

            dgvIngredients.Rows.Add(
                product.Name,
                qty,
                product.Unit,
                totalCalories,
                totalBreadUnits,
                product.PricePerUnit,
                product.Store
            );

            cmbProductName.SelectedIndex = -1;
            nudQuantity.Value = 0;
            txtUnit.Clear();
            txtPrice.Clear();
            cmbStore.SelectedIndex = -1;
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            Recipe recipe = _recipeToEdit ?? new Recipe();

            recipe.Name = txtName.Text;
            recipe.Instruction = txtInstruction.Text;
            recipe.CanBeFrozen = chkCanBeFrozen.Checked;
            recipe.PhotoPath = _photoPath;
            recipe.VideoPath = txtVideo.Text;

            recipe.Ingredients.Clear();

            foreach (DataGridViewRow row in dgvIngredients.Rows)
            {
                if (row.IsNewRow) continue;

                recipe.Ingredients.Add(new RecipeIngredient
                {
                    Name = row.Cells[0].Value?.ToString(),
                    Quantity = Convert.ToDouble(row.Cells[1].Value),
                    Unit = row.Cells[2].Value?.ToString(),
                    Calories = Convert.ToDouble(row.Cells[3].Value),
                    BreadUnits = Convert.ToDouble(row.Cells[4].Value),
                    PricePerUnit = Convert.ToDouble(row.Cells[5].Value),
                    Store = row.Cells[6].Value?.ToString()
                });
            }

            if (_recipeToEdit == null)
                MenuService.Instance.Recipes.Add(recipe);

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Images|*.jpg;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _photoPath = dlg.FileName;
                    picPhoto.Image = Image.FromFile(_photoPath);
                }
            }
        }



        

    }
}