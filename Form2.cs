using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppEdu
{
    public partial class Form2 : Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool isXValid = int.TryParse(textBox1.Text, out int x) && x != 0 && x >= -10 && x <= 20;
            labelErr1.Text = isXValid ? "" : "Число вне диапазона!\n [-10;20] \\ {0}";

            bool isYValid = int.TryParse(textBox2.Text, out int y) && y != 0 && y >= -20 && y <= 20;
            labelErr2.Text = isYValid ? "" : "Число вне диапазона!\n [-20;20] \\ {0}";

            if (isYValid && isXValid)
            {
                X = x;
                Y = y;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
