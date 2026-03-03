using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MenuPlanner.Core;
using MenuPlanner.Core.Models;




namespace MENU
{
    public partial class RecipeForm : Form
    {
        private Recipe _recipeToEdit;
        private string _photoPath;
        private List<Product> products;

        public RecipeForm()
        {
            InitializeComponent();
            products = ProductStorage.Load();
            cmbProductName.DataSource = products;
            cmbProductName.DisplayMember = "Name"; 
            cmbCategory.DataSource = CategoryService.Instance.Categories;



        }
        public RecipeForm(Recipe recipe)
        {
            InitializeComponent();

            products = ProductStorage.Load();
            cmbProductName.DataSource = products;
            cmbProductName.DisplayMember = "Name";

            cmbCategory.DataSource = CategoryService.Instance.Categories;

            _recipeToEdit = recipe;
            LoadRecipeData();
        }



        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductName.SelectedItem is Product product)
            {
                lblTotalCalories.Text = $"Калорийность: {product.CaloriesPerUnit} кКал/100";
                lblTotalBreadUnits.Text = $"ХЕ: {product.BreadUnitsPerUnit} ед/100";
            }
        }

        private void LoadRecipeData()
        {
            txtName.Text = _recipeToEdit.Name;
            txtInstruction.Text = _recipeToEdit.Instruction;
            chkCanBeFrozen.Checked = _recipeToEdit.CanBeFrozen;
            cmbCategory.SelectedItem = _recipeToEdit.Category;

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
            UpdateTotals();

        }



        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (cmbProductName.SelectedItem == null)
            {
                MessageBox.Show("Выберите продукт.");
                return;
            }

            var product = (Product)cmbProductName.SelectedItem;

            // Количество вручную
            if (!double.TryParse(txtQuantity.Text, out double qty))
            {
                MessageBox.Show("Введите корректное количество.");
                return;
            }

            string unit = txtUnit.Text;

            // Цена вручную
            double price = double.TryParse(txtPrice.Text, out double p) ? p : 0;

            string store = cmbStore.Text;

            double totalCalories = (product.CaloriesPerUnit / 100.0) * qty;
            double totalBreadUnits = (product.BreadUnitsPerUnit / 100.0) * qty;


            dgvIngredients.Rows.Add(
                product.Name,
                qty,
                unit,
                totalCalories,
                totalBreadUnits,
                price,
                store
            );

            // Очистка полей
            cmbProductName.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnit.Clear();
            txtPrice.Clear();
            cmbStore.SelectedIndex = -1;

            UpdateTotals();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Recipe recipe = _recipeToEdit ?? new Recipe();

            recipe.Name = txtName.Text;
            recipe.Instruction = txtInstruction.Text;
            recipe.CanBeFrozen = chkCanBeFrozen.Checked;
            recipe.PhotoPath = _photoPath;
            recipe.VideoPath = txtVideo.Text;
            recipe.Category = cmbCategory.SelectedItem?.ToString();


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

        private void UpdateTotals()
        {
            double totalCalories = 0;
            double totalBreadUnits = 0;
            double totalPrice = 0;

            foreach (DataGridViewRow row in dgvIngredients.Rows)
            {
                if (row.IsNewRow) continue;

                totalCalories += Convert.ToDouble(row.Cells[3].Value);
                totalBreadUnits += Convert.ToDouble(row.Cells[4].Value);

                double pricePerUnit = Convert.ToDouble(row.Cells[5].Value);
                double qty = Convert.ToDouble(row.Cells[1].Value);
                totalPrice += pricePerUnit * qty;
            }

            lblTotalCalories.Text = $"Калорийность: {totalCalories:F2}";
            lblTotalBreadUnits.Text = $"ХЕ: {totalBreadUnits:F2}";
            lblTotalPrice.Text = $"Стоимость: {totalPrice:F2} ₽";
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalCalories_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }
       

    }
}