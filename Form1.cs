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
        public double[,] matrix = new double[6, 6];

        public bool isDragging = false;
        public Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            InitMatrix();
        }

        private void InitMatrix()
        {
            Random rand = new Random();
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                matrix[0, j] = Math.Round((rand.NextDouble() * 50) - 20, 2);
                double max = matrix[0, j];

                for (int i = 1; i < 5; i++)
                {
                    matrix[i, j] = Math.Round((rand.NextDouble() * 50) - 20, 2);

                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                matrix[5, j] = max;
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
            if (cmb1.SelectedIndex < 0) return;

            int sCol = cmb1.SelectedIndex;
            int rows = matrix.GetLength(0);

            double[] sortArray = new double[rows];
            for (int i = 0; i < rows; i++)
            {
                sortArray[i] = matrix[i, sCol];
            }

            // Классическая сортировка пузырьком по возрастанию
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                for (int j = 0; j < sortArray.Length - i - 1; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        double temp = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = temp;
                    }
                }
            }

            tb1.Text += $"Отсортированный столбец {sCol + 1}: \n";
            tb1.Text += new string('-', 30) + "\n";

            for (int i = 0; i < sortArray.Length; i++)
            {
                tb1.Text += $"{sortArray[i]:F2}  ";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Сохранить результат работы текстового поля в файл перед выходом?",
                "Сохранение файла",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    sfd.Title = "Выберите место для сохранения отчета";
                    sfd.FileName = "Результат_сортировки.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.WriteAllText(sfd.FileName, tb1.Text, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true; 
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
