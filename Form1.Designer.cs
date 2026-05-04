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
            listBoxArray = new ListBox();
            textBoxAnswer1 = new TextBox();
            textBoxAnswer2 = new TextBox();
            labelArrayOutput = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxArray
            // 
            listBoxArray.FormattingEnabled = true;
            listBoxArray.Location = new Point(37, 21);
            listBoxArray.Name = "listBoxArray";
            listBoxArray.Size = new Size(167, 444);
            listBoxArray.TabIndex = 0;
            // 
            // textBoxAnswer1
            // 
            textBoxAnswer1.Location = new Point(37, 498);
            textBoxAnswer1.Name = "textBoxAnswer1";
            textBoxAnswer1.ReadOnly = true;
            textBoxAnswer1.Size = new Size(167, 27);
            textBoxAnswer1.TabIndex = 1;
            // 
            // textBoxAnswer2
            // 
            textBoxAnswer2.Location = new Point(247, 498);
            textBoxAnswer2.Name = "textBoxAnswer2";
            textBoxAnswer2.ReadOnly = true;
            textBoxAnswer2.Size = new Size(171, 27);
            textBoxAnswer2.TabIndex = 2;
            // 
            // labelArrayOutput
            // 
            labelArrayOutput.Font = new Font("Segoe UI", 8.25F);
            labelArrayOutput.Location = new Point(210, 80);
            labelArrayOutput.Name = "labelArrayOutput";
            labelArrayOutput.Size = new Size(180, 100);
            labelArrayOutput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Массив:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(label1);
            Controls.Add(labelArrayOutput);
            Controls.Add(textBoxAnswer2);
            Controls.Add(textBoxAnswer1);
            Controls.Add(listBoxArray);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Random Array Calc (no diddy this time)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxArray;
        private TextBox textBoxAnswer1;
        private TextBox textBoxAnswer2;
        private Label labelArrayOutput;
        private Label label1;
    }
}
