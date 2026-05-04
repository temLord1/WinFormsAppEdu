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
            CalculateArray();
        }

        private void CalculateArray()
        {
            listBoxArray.Items.Clear();

            int[] numbers = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-25, 31);
                listBoxArray.Items.Add($"numbers[{i}] = {numbers[i]}");
            }

            int maxElement = numbers[0];
            int maxIndex = 0;
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                    maxIndex = i;
                }
            }

            double average = sum / numbers.Length;

            string arrayAsString = string.Join(", ", numbers);
            labelArrayOutput.Text = arrayAsString + $", {average:F2}.";

            textBoxAnswer1.Text = $"Максимум: {maxElement} (№{maxIndex})";
            textBoxAnswer2.Text = $"Среднее: {average:F2}";
        }
    }
}
