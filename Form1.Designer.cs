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
            buttonCrossTheRoad = new Button();
            SuspendLayout();
            // 
            // buttonCrossTheRoad
            // 
            buttonCrossTheRoad.Location = new Point(220, 50);
            buttonCrossTheRoad.Margin = new Padding(3, 2, 3, 2);
            buttonCrossTheRoad.Name = "buttonCrossTheRoad";
            buttonCrossTheRoad.Size = new Size(129, 80);
            buttonCrossTheRoad.TabIndex = 0;
            buttonCrossTheRoad.Text = "Перейти дорогу";
            buttonCrossTheRoad.UseVisualStyleBackColor = true;
            buttonCrossTheRoad.Click += buttonCrossTheRoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCrossTheRoad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCrossTheRoad;
    }
}
