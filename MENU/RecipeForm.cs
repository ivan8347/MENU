using System;
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

        public RecipeForm()
        {
            InitializeComponent();
            cmbProductName.DataSource = ProductService.Instance.Products;
            cmbCategory.DataSource = CategoryService.Instance.Categories;
            LoadProducts();


        }
        public RecipeForm(Recipe recipe)
        {
            InitializeComponent();
            cmbProductName.DataSource = ProductService.Instance.Products;
            cmbCategory.DataSource = CategoryService.Instance.Categories;
            _recipeToEdit = recipe;
            LoadRecipeData();
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
            nudQuantity.Value = nudQuantity.Minimum;

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
        private void LoadProducts()
        {
            cmbProductName.DataSource = null;
            cmbProductName.DataSource = ProductService.Instance.Products;
            cmbProductName.DisplayMember = "Name";
        }

    }
}