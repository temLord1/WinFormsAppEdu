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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 150);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(192, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 150);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(12, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 150);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(192, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 150);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(400, 12);
            button1.Name = "button1";
            button1.Size = new Size(180, 72);
            button1.TabIndex = 4;
            button1.Text = "Красить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(400, 116);
            button2.Name = "button2";
            button2.Size = new Size(180, 72);
            button2.TabIndex = 5;
            button2.Text = "Мигание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(400, 216);
            button3.Name = "button3";
            button3.Size = new Size(180, 72);
            button3.TabIndex = 6;
            button3.Text = "Сброс";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 403);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
