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
            var sourceList = new List<Currency> { new RuRuble(), new BelRuble(), new Tenge(), new Dollar(), new Euro(), new Yuan(), new Yen(), new Won() };

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
