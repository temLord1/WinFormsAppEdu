using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using WinFormsAppEdu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppEdu
{
    public partial class Form3 : Form
    {
        private DataTable studentsTable = new DataTable();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string tempFolder = Path.GetTempPath();
                string tempDbPath = Path.Combine(tempFolder, "temp_students_db.accdb");

                if (!File.Exists(tempDbPath))
                {
                    byte[] dbBytes = Properties.Resources.DB_5_4;
                    File.WriteAllBytes(tempDbPath, dbBytes);
                }

                string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={tempDbPath};Mode=Read;";
                string query = "SELECT * FROM Students";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        studentsTable.Clear();
                        adapter.Fill(studentsTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка работы с БД: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchCriterion = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchCriterion))
            {
                MessageBox.Show("Пожалуйста, заполните необходимые данные для поиска.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow[] foundRows = studentsTable.Select($"[СНИЛС] = '{searchCriterion}'");

            if (foundRows.Length > 0)
            {
                DataRow selectedRow = foundRows[0];
                Form2 certificateForm = new Form2();
                certificateForm.MdiParent = this.MdiParent;
                certificateForm.Show();
                certificateForm.UpdateCertificateData(selectedRow);
            }
            else
            {
                MessageBox.Show("Студент не найден! Проверьте правильность введенных данных.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
