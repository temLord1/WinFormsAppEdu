using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Formats.Nrbf;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Serialization;
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

        public void SetLastStudentLastName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return;

            // Разделяем строку по пробелам и берем первое слово (Фамилию)
            string[] parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0)
            {
                label2.Text = "Последний получивший справку: " + parts[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 selectForm = new Form3();
            selectForm.MdiParent = this;
            selectForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CloseAllChildrens();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseAllChildrens();
            Application.Exit();
        }

        private void CloseAllChildrens()
        {
            for (int i = this.MdiChildren.Length - 1; i >= 0; i--)
            {
                this.MdiChildren[i].Close();
            }
        }
    }
}
