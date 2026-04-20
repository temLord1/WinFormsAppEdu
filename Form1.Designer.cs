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
            textBoxOutput = new TextBox();
            comboBoxOutput = new ComboBox();
            comboBoxInput = new ComboBox();
            textBoxInput = new TextBox();
            labelFromInfo = new Label();
            labelToInfo = new Label();
            labelFromInfoConst = new Label();
            labelToInfoConst = new Label();
            labelCrossRateInfo = new Label();
            labelExtraInfo = new Label();
            SuspendLayout();
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(234, 223);
            textBoxOutput.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.PlaceholderText = "Вывод";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(114, 27);
            textBoxOutput.TabIndex = 4;
            // 
            // comboBoxOutput
            // 
            comboBoxOutput.FormattingEnabled = true;
            comboBoxOutput.Location = new Point(407, 223);
            comboBoxOutput.Margin = new Padding(3, 4, 3, 4);
            comboBoxOutput.Name = "comboBoxOutput";
            comboBoxOutput.Size = new Size(138, 28);
            comboBoxOutput.TabIndex = 5;
            // 
            // comboBoxInput
            // 
            comboBoxInput.FormattingEnabled = true;
            comboBoxInput.Location = new Point(407, 150);
            comboBoxInput.Margin = new Padding(3, 4, 3, 4);
            comboBoxInput.Name = "comboBoxInput";
            comboBoxInput.Size = new Size(138, 28);
            comboBoxInput.TabIndex = 6;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(234, 151);
            textBoxInput.Margin = new Padding(3, 4, 3, 4);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Ввод";
            textBoxInput.Size = new Size(114, 27);
            textBoxInput.TabIndex = 7;
            // 
            // labelFromInfo
            // 
            labelFromInfo.AutoSize = true;
            labelFromInfo.Location = new Point(571, 154);
            labelFromInfo.Name = "labelFromInfo";
            labelFromInfo.Size = new Size(0, 20);
            labelFromInfo.TabIndex = 8;
            // 
            // labelToInfo
            // 
            labelToInfo.AutoSize = true;
            labelToInfo.Location = new Point(571, 227);
            labelToInfo.Name = "labelToInfo";
            labelToInfo.Size = new Size(0, 20);
            labelToInfo.TabIndex = 9;
            // 
            // labelFromInfoConst
            // 
            labelFromInfoConst.AutoSize = true;
            labelFromInfoConst.Location = new Point(355, 154);
            labelFromInfoConst.Name = "labelFromInfoConst";
            labelFromInfoConst.Size = new Size(46, 20);
            labelFromInfoConst.TabIndex = 10;
            labelFromInfoConst.Text = "From:";
            // 
            // labelToInfoConst
            // 
            labelToInfoConst.AutoSize = true;
            labelToInfoConst.Location = new Point(373, 227);
            labelToInfoConst.Name = "labelToInfoConst";
            labelToInfoConst.Size = new Size(28, 20);
            labelToInfoConst.TabIndex = 11;
            labelToInfoConst.Text = "To:";
            // 
            // labelCrossRateInfo
            // 
            labelCrossRateInfo.AutoSize = true;
            labelCrossRateInfo.Location = new Point(571, 271);
            labelCrossRateInfo.Name = "labelCrossRateInfo";
            labelCrossRateInfo.Size = new Size(0, 20);
            labelCrossRateInfo.TabIndex = 12;
            // 
            // labelExtraInfo
            // 
            labelExtraInfo.AutoSize = true;
            labelExtraInfo.Location = new Point(571, 302);
            labelExtraInfo.Name = "labelExtraInfo";
            labelExtraInfo.Size = new Size(0, 20);
            labelExtraInfo.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelExtraInfo);
            Controls.Add(labelCrossRateInfo);
            Controls.Add(labelToInfoConst);
            Controls.Add(labelFromInfoConst);
            Controls.Add(labelToInfo);
            Controls.Add(labelFromInfo);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxInput);
            Controls.Add(comboBoxOutput);
            Controls.Add(textBoxOutput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxOutput;
        private ComboBox comboBoxOutput;
        private ComboBox comboBoxInput;
        private TextBox textBoxInput;
        private Label labelFromInfo;
        private Label labelToInfo;
        private Label labelFromInfoConst;
        private Label labelToInfoConst;
        private Label labelCrossRateInfo;
        private Label labelExtraInfo;
    }
}
