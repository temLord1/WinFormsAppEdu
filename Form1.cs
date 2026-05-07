using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Formats.Nrbf;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += button1_Click;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "Массив: ";

            Random rand = new Random();
            int[] numbers = new int[20];
            int maxElement = numbers[0];
            int maxIndex = 0;
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-25, 31);
                listBox1.Items.Add($"№{i + 1} = {numbers[i]}");
                label1.Text += $"{numbers[i]}, ";

                sum += numbers[i];

                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                    maxIndex = i;
                }
            }

            double average = sum / numbers.Length;

            textBox1.Text = $"Максимум: {maxElement} (№{maxIndex})";
            textBox2.Text = $"Среднее арифметическое: {average:F2}";
            label1.Text += $"{average}.";
        }
    }
}
