using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Formats.Nrbf;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {
        public int[,] matrix = new int[12, 6];
        public int max = int.MinValue;
        public double average = 0;

        public Form1()
        {
            InitializeComponent();
            InitMatrix();
        }

        private void InitMatrix()
        {
            Random rand = new Random();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;
            int count = 0;
            int shift = 0;

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if ((i < shift) || (i > rows - shift - 2))
                    {
                        matrix[i, j] = int.MinValue;
                    }
                    else
                    {
                        int random = rand.Next(-25, 25);
                        matrix[i, j] = random;
                        sum += random;
                        count++;
                    }

                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                if (j != 5)
                {
                    matrix[rows - shift - 1, j] = max;
                }
                shift++;
                max = int.MinValue;
            }
            average = (double)sum / count;
            DisplayMatrix();
        }

        private void DisplayMatrix()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dgv1.Columns.Clear();
            dgv1.Rows.Clear();
            tb1.Clear();

            for (int j = 0; j < cols; j++)
            {
                dgv1.Columns.Add($"col{j}", "");
            }


            for (int i = 0; i < rows; i++)
            {
                dgv1.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] != int.MinValue)
                    {
                        dgv1.Rows[i].Cells[j].Value = matrix[i, j];
                        dgv1.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    }
                }
            }

            for (int i = (rows / 2) + 1, j = (cols / 2) + 1; i <= rows - 1 && j >= 0; i++, j--)
            {
                dgv1.Rows[i].Cells[j].Style.BackColor = Color.LightSteelBlue;
            }

            tb1.Text = $"Среднее значение матрицы: {average:F2}";

            AdjustMatrix();
        }

        private void AdjustMatrix()
        {
            if (dgv1.RowCount == 0) return;

            int avaibleHeight = dgv1.ClientSize.Height;
            int rowHeight = avaibleHeight / dgv1.RowCount;

            if (rowHeight < 25) rowHeight = 25;

            foreach (DataGridViewRow row in dgv1.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InitMatrix();
        }
    }
}
