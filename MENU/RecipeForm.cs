using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MenuPlanner.Core;
using MenuPlanner.Core.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Linq;



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
        // ЮТУБ//
        //Загрузка//
        private async Task LoadYoutubeData(string url)
        {
            try
            {
                string video_id = ExtractVideoId(url);
                if (video_id == null)
                {
                    MessageBox.Show("Не удалось определить ID видео.");
                    return;
                }
                string apiKey = "AIzaSyCYQPqDOFD99Aven7RknPBtXFrOZm95Yfc";
                string apiUrl =
                    $"https://www.googleapis.com/youtube/v3/videos?part=snippet&id={video_id}&key={apiKey}";
                using (HttpClient client = new HttpClient())
                {
                    string json = await client.GetStringAsync(apiUrl);


                    JObject obj = JObject.Parse(json);
                    var snippet = obj["items"]?[0]?["snippet"];
                    if (snippet == null)
                    {
                        MessageBox.Show("Не удалось получить данные о видео");
                        return;
                    }
                    string title = snippet["title"]?.ToString();
                    string description = snippet["description"]?.ToString();

                    txtName.Text = title;
                    txtInstruction.Text = description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных YouTube: " + ex.Message);
            }

        }

        private string ExtractVideoId(string url)
        {
            var match = Regex.Match(url, @"(?:v=|youtu\.be/)([A-Za-z0-9_-]{6,})");
            return match.Success ? match.Groups[1].Value : null;
        }
        private async Task<(double calories, double breadUnits)> FetchNutrition(string productName)
        {
            try
            {
                string url = $"https://api.edamam.com/api/food-database/v2/parser?ingr={Uri.EscapeDataString(productName)}";

                using (HttpClient client = new HttpClient())
                {
                    string json = await client.GetStringAsync(url);

                    JObject obj = JObject.Parse(json);

                    var nutrients = obj["parsed"]?[0]?["food"]?["nutrients"];
                    if (nutrients == null)
                        return (0, 0);

                    double calories = nutrients["ENERC_KCAL"]?.ToObject<double>() ?? 0;
                    double carbs = nutrients["CHOCDF"]?.ToObject<double>() ?? 0;

                    double breadUnits = carbs / 12.0;

                    return (calories, breadUnits);
                }
            }
            catch
            {
                return (0, 0);
            }
        }
        private async Task<Product> EnsureProductExists(string name)
        {
            var product = products.FirstOrDefault(
                p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product != null)
                return product;

            var result = MessageBox.Show(
                $"Продукт \"{name}\" не найден. Найти данные в интернете?",
                "Новый продукт",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return null;

            var (calories, bu) = await FetchNutrition(name);

            if (calories == 0)
            {
                MessageBox.Show("Не удалось найти данные. Введите вручную.");

                string caloriesStr = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Введите калорийность (кКал на 100 г) для \"{name}\":",
                    "Новый продукт");

                string buStr = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Введите ХЕ (на 100 г) для \"{name}\":",
                    "Новый продукт");

                if (!double.TryParse(caloriesStr, out calories) ||
                    !double.TryParse(buStr, out bu))
                {
                    MessageBox.Show("Ошибка: неверный формат чисел.");
                    return null;
                }
            }

            product = new Product
            {
                Name = name,
                CaloriesPerUnit = calories,
                BreadUnitsPerUnit = bu
            };

            ProductStorage.AddProduct(product);

            products = ProductStorage.Load();

            cmbProductName.DataSource = null;
            cmbProductName.DataSource = products;
            cmbProductName.DisplayMember = "Name";

            return product;
        }

        private async void RecipeForm_Load(object sender, EventArgs e)
        {
            string clip = Clipboard.GetText();

            if (clip.Contains("youtube.com") || clip.Contains("youtu.be"))
            {
                txtVideo.Text = clip.Trim();
                await LoadYoutubeData(clip.Trim());
            }
        }
        private static readonly Dictionary<char, double> FractionMap = new Dictionary<char, double>()

        {
            ['¼'] = 0.25,
            ['½'] = 0.5,
            ['¾'] = 0.75,
            ['⅐'] = 1.0 / 7,
            ['⅑'] = 1.0 / 9,
            ['⅒'] = 0.1,
            ['⅓'] = 1.0 / 3,
            ['⅔'] = 2.0 / 3,
            ['⅕'] = 0.2,
            ['⅖'] = 0.4,
            ['⅗'] = 0.6,
            ['⅘'] = 0.8,
            ['⅙'] = 1.0 / 6,
            ['⅚'] = 5.0 / 6,
            ['⅛'] = 0.125,
            ['⅜'] = 0.375,
            ['⅝'] = 0.625,
            ['⅞'] = 0.875
        };

        private async Task ParseIngredients(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            dgvIngredients.Rows.Clear();

            var regex = new Regex(
                @"(.+?)\s*[-–—:]\s*([\d¼½¾⅐⅑⅒⅓⅔⅕⅖⅗⅘⅙⅚⅛⅜⅝⅞]+)\s*(г|гр|мл|шт|ст\.л\.|ч\.л\.|стакан)",
                RegexOptions.IgnoreCase);

            var lines = text.Split('\n');

            foreach (var line in lines)
            {
                var match = regex.Match(line.Trim());
                if (!match.Success)
                    continue;

                string name = match.Groups[1].Value.Trim();
                string qtyStr = match.Groups[2].Value.Trim();
                string unit = match.Groups[3].Value.Trim();

                // Преобразуем количество
                double qty = ParseQuantitySmart(qtyStr);

                // Ищем продукт в базе
                var product = await EnsureProductExists(name);
                if (product == null)
                    continue;

                // Рассчитываем калории и ХЕ
                double calories = (product.CaloriesPerUnit / 100.0) * qty;
                double breadUnits = (product.BreadUnitsPerUnit / 100.0) * qty;

                dgvIngredients.Rows.Add(
                    product.Name,
                    qty,
                    unit,
                    calories,
                    breadUnits,
                    0,
                    ""
                );
            }
        }
        private double ParseQuantitySmart(string input)
        {
            input = input.Trim().ToLower();

            // 1. Словесные количества
            if (WordQuantities.TryGetValue(input, out double wordValue))
                return wordValue;

            // 2. Обычное число
            if (double.TryParse(input, out double value))
                return value;

            // 3. Дробные символы
            var map = new Dictionary<char, double>
            {
                ['¼'] = 0.25,
                ['½'] = 0.5,
                ['¾'] = 0.75,
                ['⅐'] = 1.0 / 7,
                ['⅑'] = 1.0 / 9,
                ['⅒'] = 0.1,
                ['⅓'] = 1.0 / 3,
                ['⅔'] = 2.0 / 3,
                ['⅕'] = 0.2,
                ['⅖'] = 0.4,
                ['⅗'] = 0.6,
                ['⅘'] = 0.8,
                ['⅙'] = 1.0 / 6,
                ['⅚'] = 5.0 / 6,
                ['⅛'] = 0.125,
                ['⅜'] = 0.375,
                ['⅝'] = 0.625,
                ['⅞'] = 0.875
            };

            double result = 0;

            // 4. Смешанные дроби: 1½
            string digits = new string(input.TakeWhile(char.IsDigit).ToArray());
            if (digits.Length > 0)
            {
                result += double.Parse(digits);
                input = input.Substring(digits.Length);
            }

            if (input.Length == 1 && map.ContainsKey(input[0]))
                result += map[input[0]];

            return result;
        }


        private async void btnParseInstruction_Click(object sender, EventArgs e)
        {
            dgvIngredients.Rows.Clear();
            string text = txtInstruction.Text;
            await ParseIngredients(text);
            UpdateTotals();
        }
        private static readonly Dictionary<string, double> WordQuantities = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
             { "щепотка", 1 },{ "щепотки", 1 },{ "по вкусу", 0 },{ "немного", 5 },{ "чуть-чуть", 3 },
             { "капля", 1 },{ "капли", 1 },{ "кусочек", 10 },{ "пакетик", 10 }

        };

    }
}