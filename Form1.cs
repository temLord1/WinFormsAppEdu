using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Formats.Nrbf;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {

        public double Price;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(31);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, panel1.Width, panel1.Height);
            Region roundRegion = new Region(path);
            panel1.Region = roundRegion;
            panel1.BackColor = Color.White;
        }
        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.BackColor = GetColor(Convert.ToString(comboBoxColors.SelectedItem));
        }

        private void comboBoxFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price = GetPrice(Convert.ToString(comboBoxFlowers.SelectedItem));
            UpdateSummaryTextBox();
        }
        private void textBoxFlowers_TextChanged(object sender, EventArgs e)
        {
            UpdateSummaryTextBox();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidRussianString(textBoxSurname.Text) && textBoxSurname.Text != "")
            {
                labelErr1.Text = " - Некорректный ввод!!";
            }
            else labelErr1.Text = "";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidRussianString(textBoxName.Text) && textBoxName.Text != "")
            {
                labelErr2.Text = " - Некорректный ввод!!";
            }
            else labelErr2.Text = "";
        }

        private void textBoxFathname_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidRussianString(textBoxFathname.Text) && textBoxFathname.Text != "")
            {
                labelErr3.Text = " - Некорректный ввод!!";
            }
            else labelErr3.Text = "";
        }

        private void textBoxLetter_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidRussianString(textBoxLetter.Text) && textBoxLetter.Text != "")
            {
                labelErr4.Text = " - Некорректный ввод!!";
            }
            else labelErr4.Text = "";
        }

        private void UpdateSummaryTextBox()
        {
            if (comboBoxFlowers.SelectedItem != null && textBoxFlowers.Text != "")
            {
                bool isValid = double.TryParse(textBoxFlowers.Text, out double quantity);
                if (!isValid) textBoxSummary.Text = null;

                textBoxSummary.Text = $"{(Price * quantity):C2}";
            }
            else
            {
                textBoxSummary.Text = null;
            }
        }
        public Color GetColor(string? wrapping)
        {
            Color color = Color.White;
            switch (wrapping)
            {
                case "Красный":
                    color = Color.Red;
                    break;
                case "Синий":
                    color = Color.Blue;
                    break;
                case "Зелёный":
                    color = Color.Green;
                    break;
                case "Жёлтый":
                    color = Color.Yellow;
                    break;
            }
            return color;
        }

        public double GetPrice(string? flower)
        {
            double price = 0;
            switch (flower)
            {
                case "Розы":
                    price = 120;
                    break;
                case "Тюльпаны":
                    price = 100;
                    break;
                case "Лилии":
                    price = 140;
                    break;
                case "Ромашки":
                    price = 80;
                    break;
                case "Орхидеи":
                    price = 160;
                    break;
            }
            return price;
        }

        public bool IsValidRussianString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            char firstChar = str[0];
            bool startsWithCapital = firstChar >= 'А' && firstChar <= 'Я';
            if (firstChar == 'Ё')
                startsWithCapital = true;

            bool hasNoDigits = !str.Any(char.IsDigit);
            return startsWithCapital && hasNoDigits;
        }
    }
}
