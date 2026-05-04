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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAnswer1 = new Button();
            label1 = new Label();
            textBoxX = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxN = new TextBox();
            textBoxAnswer1 = new TextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            buttonAnswer2 = new Button();
            textBoxAnswer2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonAnswer1
            // 
            buttonAnswer1.Location = new Point(36, 192);
            buttonAnswer1.Name = "buttonAnswer1";
            buttonAnswer1.Size = new Size(176, 38);
            buttonAnswer1.TabIndex = 0;
            buttonAnswer1.Text = "Вычислить ответ";
            buttonAnswer1.UseVisualStyleBackColor = true;
            buttonAnswer1.Click += buttonAnswer1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 1;
            label1.Text = "Вычислить:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(63, 136);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(53, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 49);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 4;
            label2.Text = "Введите:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 5;
            label3.Text = "Х =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(230, 136);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 6;
            label4.Text = "N =";
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(280, 136);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(125, 27);
            textBoxN.TabIndex = 7;
            // 
            // textBoxAnswer1
            // 
            textBoxAnswer1.Location = new Point(280, 198);
            textBoxAnswer1.Name = "textBoxAnswer1";
            textBoxAnswer1.ReadOnly = true;
            textBoxAnswer1.Size = new Size(228, 27);
            textBoxAnswer1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 268);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 9;
            label5.Text = "Вычислить:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(109, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 74);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // buttonAnswer2
            // 
            buttonAnswer2.Location = new Point(36, 424);
            buttonAnswer2.Name = "buttonAnswer2";
            buttonAnswer2.Size = new Size(176, 38);
            buttonAnswer2.TabIndex = 11;
            buttonAnswer2.Text = "Вычислить ответ";
            buttonAnswer2.UseVisualStyleBackColor = true;
            buttonAnswer2.Click += buttonAnswer2_Click;
            // 
            // textBoxAnswer2
            // 
            textBoxAnswer2.Location = new Point(280, 430);
            textBoxAnswer2.Name = "textBoxAnswer2";
            textBoxAnswer2.ReadOnly = true;
            textBoxAnswer2.Size = new Size(228, 27);
            textBoxAnswer2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(153, 180, 209);
            ClientSize = new Size(582, 553);
            Controls.Add(textBoxAnswer2);
            Controls.Add(buttonAnswer2);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(textBoxAnswer1);
            Controls.Add(textBoxN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxX);
            Controls.Add(label1);
            Controls.Add(buttonAnswer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "What is this diddy blud doin' on the calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnswer1;
        private Label label1;
        private TextBox textBoxX;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxN;
        private TextBox textBoxAnswer1;
        private Label label5;
        private PictureBox pictureBox2;
        private Button buttonAnswer2;
        private TextBox textBoxAnswer2;
    }
}
