using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private double Factorial(int n)
        {
            double res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxX.Text, out double x) || !int.TryParse(textBoxN.Text, out int n))
            {
                textBoxAnswer1.Text = "Ошибка ввода!";
                return;
            }
            if (n <= 0)
            {
                textBoxAnswer1.Text = "N должно быть > 0";
                return;
            }
            if (n > 100000)
            {
                textBoxAnswer1.Text = "N слишком велико";
                return;
            }
            if (Math.Abs(x) > 100)
            {
                textBoxAnswer1.Text = "X вне диапазона";
                return;
            }

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double power = Math.Pow(x, i);

                if (double.IsInfinity(power)) break;

                sum += Math.Sin(power);
            }
            textBoxAnswer1.Text = sum.ToString("F6");
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            double totalSum = 0;
            for (int n = 1; n <= 10; n++)
            {
                double numerator = Math.Pow(Factorial(n), 2);
                double denominator = Factorial(2 * n);
                totalSum += numerator / denominator;
            }
            textBoxAnswer2.Text = totalSum.ToString("F10");
        }
    }
}
