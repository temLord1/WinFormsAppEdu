using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Formats.Nrbf;
using System.Security.Cryptography;
using System.Transactions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {
        public double[,] matrix;
        public int x = 1;
        public int y = 1;

        public bool isDragging = false;
        public Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            InitMatrix(10, 10);
            AskForParameters();
        }

        private void InitMatrix(int rows, int columns)
        {
            matrix = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    int i_math = i + 1;
                    int j_math = j + 1;
                    if (i_math > j_math)
                    {
                        matrix[i, j] = ((x + y) * i_math) / ((2 * x + y * Math.Exp(x)) * x);
                    }
                    else if (j_math == i_math)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = Math.Exp(i_math * x + y) / (y * i_math);
                    }
                }
            }

            DisplayMatrix();
        }

        private void DisplayMatrix()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dgv1.Columns.Clear();
            dgv1.Rows.Clear();
            cmb1.Items.Clear();

            for (int j = 0; j < cols; j++)
            {
                dgv1.Columns.Add($"col{j}", "");
                cmb1.Items.Add($"Столбец {j + 1}");
            }

            for (int i = 0; i < rows; i++)
            {
                dgv1.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dgv1.Rows[i].Cells[j].Value = matrix[i, j].ToString("G2");
                }
            }

            if (cmb1.Items.Count > 0)
            {
                cmb1.SelectedIndex = 0;
            }

            AdjustMatrix();
        }

        private void AskForParameters()
        {
            using (Form2 inputForm = new Form2())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    x = inputForm.X;
                    y = inputForm.Y;

                    InitMatrix(10, 10);
                }
            }
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dgv1.ClearSelection();
                AskForParameters();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToClient(Cursor.Position);
                panel1.Left = p.X - startPoint.X;
                panel1.Top = p.Y - startPoint.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.SelectedIndex < 0 || matrix == null) return;

            int sCol = cmb1.SelectedIndex;
            int rowsCount = matrix.GetLength(0);
            double sum = 0;
            double maxVal = double.MinValue;
            double firstMin = double.MaxValue;
            double secondMin = double.MaxValue;
            double avgVal = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                double current = matrix[i, sCol];

                sum += current;

                if (current > maxVal)
                {
                    maxVal = current;
                }

                if (current < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = current;
                }
                else if (current < secondMin && current != firstMin)
                {
                    secondMin = current;
                }
            }

            avgVal = sum / rowsCount;

            tb1.Text = $"Среднее: {avgVal:G6}";
            tb2.Text = $"Максимум: {maxVal:G6}";
            bool isExist = secondMin == double.MaxValue;
            tb3.Text = isExist ? "2-й минимум: нет" : $"2-й минимум: {secondMin:G6}";

            if (dgv1.ColumnCount > 0)
            {
                dgv1.ClearSelection();
                foreach (DataGridViewRow row in dgv1.Rows)
                {
                    row.Cells[sCol].Selected = true;
                }
            }
        }
    }
}
