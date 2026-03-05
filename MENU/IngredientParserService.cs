using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MENU
{
    public class IngredientParserService
    {
        private readonly ProductService _products;

        public IngredientParserService(ProductService products)
        {
            _products = products;
        }

        public async Task<List<ParsedIngredient>> ParseAsync(string text)
        {
            var result = new List<ParsedIngredient>();

            if (string.IsNullOrWhiteSpace(text))
                return result;

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

                double qty = ParseQuantity(qtyStr);

                var product = _products.EnsureExists(name);
                if (product == null)
                    continue;

                result.Add(new ParsedIngredient
                {
                    Name = name,
                    Quantity = qty,
                    Unit = unit,
                    Calories = product.CaloriesPerUnit * qty / 100.0,
                    BreadUnits = product.BreadUnitsPerUnit * qty / 100.0
                });
            }

            return result;
        }

        private double ParseQuantity(string input)
        {
            input = input.Trim().ToLower();

            if (WordQuantities.TryGetValue(input, out double wordValue))
                return wordValue;

            if (double.TryParse(input, out double value))
                return value;

            var map = FractionMap;

            double result = 0;

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

        private static readonly Dictionary<char, double> FractionMap = new Dictionary<char, double>
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

        private static readonly Dictionary<string, double> WordQuantities =
            new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
            {
                { "щепотка", 1 },   { "щепотки", 1 },   { "по вкусу", 0 },
                { "немного", 5 },   { "чуть-чуть", 3 },
                { "капля", 1 },     { "капли", 1 },
                { "кусочек", 10 },  { "пакетик", 10 }
            };
    }

    public class ParsedIngredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public double BreadUnits { get; set; }
    }
}
