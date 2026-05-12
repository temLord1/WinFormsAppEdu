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
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(14, 9);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(132, 349);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(375, 92);
            label1.Name = "label1";
            label1.Size = new Size(123, 125);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 386);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 386);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(375, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(123, 74);
            button1.TabIndex = 4;
            button1.Text = "Генерировать новые массивы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(375, 230);
            label2.Name = "label2";
            label2.Size = new Size(123, 125);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(178, 9);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.Size = new Size(132, 349);
            listBox2.TabIndex = 6;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(14, 363);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(509, 415);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Контрольная работа Вариант 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
    }
}
