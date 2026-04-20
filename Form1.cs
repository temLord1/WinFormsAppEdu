using System.Xml.Serialization;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCurrencies();
        }

        private void InitializeCurrencies()
        {
            var sourceList = new List<Currency> { new Currency("Россйский рубль", "RUB", 1, 1), new Currency("Белорусский рубль", "BYN", 26.8352, 1),
                new Currency("Тенге", "KZT", 16.1315, 100), new Currency("Доллар США", "USD", 76.0535, 1), new Currency("Евро", "EUR", 89.6256, 1), 
                new Currency("Юань", "CNY", 11.1457, 1), new Currency("Иен", "JPY", 47.6824, 100), new Currency("Вон", "KRW", 51.6457, 1000) };

            comboBoxInput.DisplayMember = "CurrencyName";
            comboBoxInput.DataSource = sourceList.ToArray();
            comboBoxOutput.DisplayMember = "CurrencyName";
            comboBoxOutput.DataSource = sourceList.ToArray();

            textBoxInput.TextChanged += Calculate;
            comboBoxInput.SelectionChangeCommitted += Calculate;
            comboBoxOutput.SelectionChangeCommitted += Calculate;
        }

        private void Calculate(object? sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double amount) &&
                comboBoxInput.SelectedItem is Currency fromCurrency &&
                comboBoxOutput.SelectedItem is Currency toCurrency)
            {
                double result = fromCurrency.ExchangeTo(toCurrency, amount);
                textBoxOutput.Text = result.ToString("F2");

                labelFromInfo.Text = $"Курс от RUB к {fromCurrency.StringCode}: {fromCurrency.ExchangeRate:F2} за {fromCurrency.Quantity} ед.";
                labelToInfo.Text = $"Курс от RUB к {toCurrency.StringCode}: {toCurrency.ExchangeRate:F2} за {toCurrency.Quantity} ед.";

                double crossRate = fromCurrency.ExchangeTo(toCurrency, 1);
                labelCrossRateInfo.Text = $"1 {fromCurrency.StringCode} = {crossRate:F4} {toCurrency.StringCode}";

                labelExtraInfo.Text = "* По данным Центробанка РФ от 18.04.2026 г.";
            }
            else
            {
                textBoxOutput.Text = "";
                labelFromInfo.Text = "Некорректный ввод!";
                labelToInfo.Text = "";
                labelCrossRateInfo.Text = "";
                labelExtraInfo.Text = "";
            }
        }
    }
}
