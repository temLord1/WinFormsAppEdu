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
        public bool isProgrammaticChange = false;

        public Form1()
        {
            InitializeComponent();
            Load += button1_Click;
            textBox2.TextChanged += FindElement;
            button1.Click += FindElement;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label1.Text = "Массив 1: ";
            label2.Text = "Массив 2: ";

            Random rand = new Random();
            int[] numbers1 = new int[20];
            int[] numbers2 = new int[25];

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rand.Next(-25, 31);
                listBox1.Items.Add($"№{i + 1} = {numbers1[i]}");
                label1.Text += $"{numbers1[i]}, ";
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = rand.Next(-25, 31);
                listBox2.Items.Add($"№{i + 1} = {numbers2[i]}");
                label2.Text += $"{numbers2[i]}, ";
            }
        }

        private void FindElement(object? sender, EventArgs e)
        {
            isProgrammaticChange = true;

            listBox1.ClearSelected();
            listBox2.ClearSelected();

            if (!int.TryParse(textBox2.Text, out int number))
            {
                label3.Text = "Некорректный ввод!";
                if (textBox2.Text == "")
                {
                    label3.Text = "";
                }
                isProgrammaticChange = false;
                return;
            }

            label3.Text = "";
            string searchPattern = "= " + number.ToString();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string itemText = listBox1.Items[i].ToString();

                if (itemText.EndsWith(searchPattern))
                {
                    listBox1.SelectedIndex = i;
                }
            }

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string itemText = listBox2.Items[i].ToString();

                if (itemText.EndsWith(searchPattern))
                {
                    listBox2.SelectedIndex = i;
                }
            }

            isProgrammaticChange = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isProgrammaticChange)
            {
                FindElement(sender, e);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isProgrammaticChange)
            {
                FindElement(sender, e);
            }
        }
    }
}
