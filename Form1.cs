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
        public int[][] jaggedArray;
        public int max = int.MinValue;
        public double average = 0;

        public Form1()
        {
            InitializeComponent();
            InitArray();
        }

        private void InitArray()
        {
            Random rand = new Random();
            jaggedArray = new int[6][];
            int currentLength = 12;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (i == jaggedArray.Length - 1)
                {
                    jaggedArray[i] = new int[1];
                    jaggedArray[i][0] = rand.Next(-25, 26);
                    continue;
                }

                jaggedArray[i] = new int[currentLength];
                int maxVal = int.MinValue;
                int oddCount = currentLength - 1;

                for (int j = 0; j < oddCount; j++)
                {
                    jaggedArray[i][j] = rand.Next(-25, 26);

                    if (jaggedArray[i][j] > maxVal)
                    {
                        maxVal = jaggedArray[i][j];
                    }
                }
                jaggedArray[i][oddCount] = maxVal;
                currentLength -= 2;
            }
            DisplayMatrix();
        }

        private void DisplayMatrix()
        {
            dgv1.Columns.Clear();
            dgv1.Rows.Clear();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                dgv1.Columns.Add($"Col{i}", $"Столбец {i + 1}");
            }

            dgv1.Rows.Add(12);

            for (int col = 0; col < jaggedArray.Length; col++)
            {
                int indent = col;

                for (int elementIndex = 0; elementIndex < jaggedArray[col].Length; elementIndex++)
                {
                    int targetRow = elementIndex + indent;
                    dgv1.Rows[targetRow].Cells[col].Value = jaggedArray[col][elementIndex];
                    dgv1.Rows[targetRow].Cells[col].Style.BackColor = Color.LightBlue;

                    if (col < 5 && elementIndex == jaggedArray[col].Length - 1)
                    {
                        dgv1.Rows[targetRow].Cells[col].Style.BackColor = Color.LightSteelBlue;
                    }
                }
            }

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
            InitArray();
        }
    }
}
