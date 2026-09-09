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
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayMatrix()
        {
            int rowCount = MatrixProvider.matrix!.GetLength(0);
            int colCount = MatrixProvider.matrix!.GetLength(1);

            if (colCount == 0 || MatrixProvider.headers == null || MatrixProvider.headers.Length == 0) // Проверка, что данные с MatrixProvider можно безопасно перенести в Dgv.
            {
                MessageBox.Show("Не удалось отобразить матрицу: данные отсутствуют или повреждены.", "Ошибка отображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            textBox1.Text = MatrixProvider.FindShopsStatistic();

            string[] shops = new string[MatrixProvider.FileStringsCount(MatrixProvider.READPATH)];
            string[] MONTHS = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль",
            "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            if (colCount > 0)
            {
                for (int j = 0; j < colCount; j++)
                {
                    string shop = MatrixProvider.headers?[j] ?? "";
                    dataGridView1.Columns.Add(shop, shop);
                    shops[j] = shop;
                }
            }

            comboBox1.DataSource = shops;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
            textBox2.Text = "";


            for (int i = 0; i < rowCount; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = MONTHS[i];

                for (int j = 0; j < colCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = MatrixProvider.matrix![i, j];
                    if (i == MatrixProvider.rowsMaxIdx && j == MatrixProvider.colsMinIdx)
                    {
                        var LightLavander = ColorTranslator.FromHtml("#CEACB3");
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = LightLavander;
                    }
                    else if (i == MatrixProvider.rowsMaxIdx)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightCoral;

                    }
                    else if (j == MatrixProvider.colsMinIdx)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            MatrixProvider.GenerateTextFile();
            MatrixProvider.ReadMatrixFile();
            DisplayMatrix();
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            MatrixProvider.ReadMatrixFile();
            DisplayMatrix();
            dataGridView1.ClearSelection();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MatrixProvider.ReadMatrixFile();
            textBox2.Text = $"Сумма продаж магазина {comboBox1.SelectedIndex + 1}  -  {MatrixProvider.colsSums![comboBox1.SelectedIndex]}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MatrixProvider.ReadMatrixFile();
            MatrixProvider.WriteStatisticFile();
            MessageBox.Show("Успешно записано!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGoldenrodYellow;
        }
    }
}
