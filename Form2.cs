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
        public Form2()
        {
            InitializeComponent();
        }

        public void UpdateCertificateData(System.Data.DataRow studentRow)
        {
            if (studentRow == null) return;


            string birthDate = "";
            if (studentRow["Дата_рождения"] != DBNull.Value)
            {
                birthDate = Convert.ToDateTime(studentRow["Дата_рождения"]).ToString("dd.MM.yyyy");
            }

            string fio_private = Convert.ToString(studentRow["ФИО_Именительный"])!.Trim();
            string fio = Convert.ToString(studentRow["ФИО_Дательный"])!.Trim();
            string course = Convert.ToString(studentRow["Курс"])!.Trim();
            string group = Convert.ToString(studentRow["Группа"])!.Trim();
            string department = Convert.ToString(studentRow["Подразделение"])!.Trim();
            string eduLevel = Convert.ToString(studentRow["Уровень_образования"])!.Trim();
            string studyForm = Convert.ToString(studentRow["Форма_обучения"])!.Trim();
            string studyBasis = Convert.ToString(studentRow["Основа_обучения"])!.Trim();
            string specialty = Convert.ToString(studentRow["Специальность"])!.Trim();
            string studyPeriod = Convert.ToString(studentRow["Период_обучения"])!.Trim();

            Color textColor = Color.Black;

            richTextBoxLeft.Clear();

            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxLeft.SelectionColor = textColor;
            richTextBoxLeft.AppendText("Дана ");
            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Underline);
            richTextBoxLeft.AppendText(fio + "\n");

            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxLeft.SelectionColor = textColor;
            richTextBoxLeft.AppendText("Дата рождения: ");
            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxLeft.AppendText(birthDate + "\n");

            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxLeft.SelectionColor = textColor;
            richTextBoxLeft.AppendText($"в том, что он обучается на {course} курсе\n");

            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxLeft.SelectionColor = textColor;
            richTextBoxLeft.AppendText("Подразделение: ");
            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxLeft.AppendText(department + "\n");

            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxLeft.SelectionColor = textColor;
            richTextBoxLeft.AppendText("Группа: ");
            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxLeft.AppendText(group + "\n");

            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxLeft.SelectionColor = textColor;
            richTextBoxLeft.AppendText("Уровень образования: ");
            richTextBoxLeft.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxLeft.AppendText(eduLevel);

            richTextBoxRight.Clear();

            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxRight.SelectionColor = textColor;
            richTextBoxRight.AppendText("Форма обучения: ");
            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxRight.AppendText(studyForm + "\n");

            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxRight.SelectionColor = textColor;
            richTextBoxRight.AppendText("Основа обучения: ");
            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxRight.AppendText(studyBasis + "\n");

            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxRight.SelectionColor = textColor;
            richTextBoxRight.AppendText("Специальность: ");
            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxRight.AppendText(specialty + "\n");

            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
            richTextBoxRight.SelectionColor = textColor;
            richTextBoxRight.AppendText("Период обучения: ");
            richTextBoxRight.SelectionFont = new Font("Times New Roman", 11, FontStyle.Regular);
            richTextBoxRight.AppendText(studyPeriod);

            if (this.MdiParent is Form1 mainForm)
            {
                mainForm.SetLastStudentLastName(fio_private);
            }
        }
    }

}
