namespace WinFormsAppEdu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxFlowers = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxColors = new ComboBox();
            label5 = new Label();
            textBoxFlowers = new TextBox();
            label6 = new Label();
            textBoxLetter = new TextBox();
            label7 = new Label();
            textBoxSummary = new TextBox();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxFathname = new TextBox();
            labelFathname = new Label();
            labelErr1 = new Label();
            labelErr2 = new Label();
            labelErr3 = new Label();
            labelErr4 = new Label();
            SuspendLayout();
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(34, 14);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(73, 20);
            labelSurname.TabIndex = 0;
            labelSurname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(34, 37);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(335, 27);
            textBoxSurname.TabIndex = 1;
            textBoxSurname.TextChanged += textBoxSurname_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(34, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxFlowers
            // 
            comboBoxFlowers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFlowers.FormattingEnabled = true;
            comboBoxFlowers.Items.AddRange(new object[] { "Розы", "Тюльпаны", "Лилии", "Ромашки", "Орхидеи" });
            comboBoxFlowers.Location = new Point(34, 249);
            comboBoxFlowers.Name = "comboBoxFlowers";
            comboBoxFlowers.Size = new Size(335, 28);
            comboBoxFlowers.TabIndex = 3;
            comboBoxFlowers.SelectedIndexChanged += comboBoxFlowers_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(375, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(64, 64);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 173);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 5;
            label2.Text = "Дата доставки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 226);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Цветы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 280);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 7;
            label4.Text = "Цвет упаковки";
            // 
            // comboBoxColors
            // 
            comboBoxColors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColors.FormattingEnabled = true;
            comboBoxColors.Items.AddRange(new object[] { "Красный", "Синий", "Зелёный", "Жёлтый" });
            comboBoxColors.Location = new Point(34, 303);
            comboBoxColors.Name = "comboBoxColors";
            comboBoxColors.Size = new Size(335, 28);
            comboBoxColors.TabIndex = 8;
            comboBoxColors.SelectedIndexChanged += comboBoxColors_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 334);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 9;
            label5.Text = "Количество цветов";
            // 
            // textBoxFlowers
            // 
            textBoxFlowers.Location = new Point(34, 360);
            textBoxFlowers.Name = "textBoxFlowers";
            textBoxFlowers.Size = new Size(335, 27);
            textBoxFlowers.TabIndex = 10;
            textBoxFlowers.TextChanged += textBoxFlowers_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 390);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 11;
            label6.Text = "Надпись на открытке";
            // 
            // textBoxLetter
            // 
            textBoxLetter.Location = new Point(34, 413);
            textBoxLetter.Name = "textBoxLetter";
            textBoxLetter.Size = new Size(335, 27);
            textBoxLetter.TabIndex = 12;
            textBoxLetter.TextChanged += textBoxLetter_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 491);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 13;
            label7.Text = "Итоговая цена";
            // 
            // textBoxSummary
            // 
            textBoxSummary.Location = new Point(34, 514);
            textBoxSummary.Name = "textBoxSummary";
            textBoxSummary.ReadOnly = true;
            textBoxSummary.Size = new Size(335, 27);
            textBoxSummary.TabIndex = 14;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(34, 90);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(335, 27);
            textBoxName.TabIndex = 16;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(34, 67);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 20);
            labelName.TabIndex = 15;
            labelName.Text = "Имя";
            // 
            // textBoxFathname
            // 
            textBoxFathname.Location = new Point(34, 143);
            textBoxFathname.Name = "textBoxFathname";
            textBoxFathname.Size = new Size(335, 27);
            textBoxFathname.TabIndex = 18;
            textBoxFathname.TextChanged += textBoxFathname_TextChanged;
            // 
            // labelFathname
            // 
            labelFathname.AutoSize = true;
            labelFathname.Location = new Point(34, 120);
            labelFathname.Name = "labelFathname";
            labelFathname.Size = new Size(72, 20);
            labelFathname.TabIndex = 17;
            labelFathname.Text = "Отчество";
            // 
            // labelErr1
            // 
            labelErr1.AutoSize = true;
            labelErr1.Location = new Point(375, 40);
            labelErr1.Name = "labelErr1";
            labelErr1.Size = new Size(0, 20);
            labelErr1.TabIndex = 19;
            // 
            // labelErr2
            // 
            labelErr2.AutoSize = true;
            labelErr2.Location = new Point(375, 97);
            labelErr2.Name = "labelErr2";
            labelErr2.Size = new Size(0, 20);
            labelErr2.TabIndex = 20;
            // 
            // labelErr3
            // 
            labelErr3.AutoSize = true;
            labelErr3.Location = new Point(375, 150);
            labelErr3.Name = "labelErr3";
            labelErr3.Size = new Size(0, 20);
            labelErr3.TabIndex = 21;
            // 
            // labelErr4
            // 
            labelErr4.AutoSize = true;
            labelErr4.Location = new Point(375, 416);
            labelErr4.Name = "labelErr4";
            labelErr4.Size = new Size(0, 20);
            labelErr4.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 553);
            Controls.Add(labelErr4);
            Controls.Add(labelErr3);
            Controls.Add(labelErr2);
            Controls.Add(labelErr1);
            Controls.Add(textBoxFathname);
            Controls.Add(labelFathname);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(textBoxSummary);
            Controls.Add(label7);
            Controls.Add(textBoxLetter);
            Controls.Add(label6);
            Controls.Add(textBoxFlowers);
            Controls.Add(label5);
            Controls.Add(comboBoxColors);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(comboBoxFlowers);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxSurname);
            Controls.Add(labelSurname);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Контрольная работа Вариант 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSurname;
        private TextBox textBoxSurname;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxFlowers;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxColors;
        private Label label5;
        private TextBox textBoxFlowers;
        private Label label6;
        private TextBox textBoxLetter;
        private Label label7;
        private TextBox textBoxSummary;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxFathname;
        private Label labelFathname;
        private Label labelErr1;
        private Label labelErr2;
        private Label labelErr3;
        private Label labelErr4;
    }
}
