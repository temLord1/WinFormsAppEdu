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
            buttonReset = new Button();
            buttonAlarm = new Button();
            pnlWindow = new Panel();
            pnlDoor = new Panel();
            SuspendLayout();
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(680, 20);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(100, 40);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonAlarm
            // 
            buttonAlarm.Location = new Point(550, 20);
            buttonAlarm.Name = "buttonAlarm";
            buttonAlarm.Size = new Size(120, 40);
            buttonAlarm.TabIndex = 4;
            buttonAlarm.Text = "Сигнализация";
            buttonAlarm.UseVisualStyleBackColor = true;
            buttonAlarm.Click += buttonAlarm_Click;
            // 
            // pnlWindow
            // 
            pnlWindow.BackColor = Color.LightSkyBlue;
            pnlWindow.Location = new Point(275, 360);
            pnlWindow.Name = "pnlWindow";
            pnlWindow.Size = new Size(90, 90);
            pnlWindow.TabIndex = 0;
            pnlWindow.Paint += pnlWindow_Paint;
            pnlWindow.Click += SecurityZone_Click;
            pnlWindow.Click += Window_Click;
            // 
            // pnlDoor
            // 
            pnlDoor.BackColor = Color.SaddleBrown;
            pnlDoor.Location = new Point(435, 410);
            pnlDoor.Name = "pnlDoor";
            pnlDoor.Size = new Size(70, 110);
            pnlDoor.TabIndex = 1;
            pnlDoor.Paint += pnlDoor_Paint;
            pnlDoor.Click += SecurityZone_Click;
            pnlDoor.Click += Door_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(pnlWindow);
            Controls.Add(pnlDoor);
            Controls.Add(buttonReset);
            Controls.Add(buttonAlarm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Умный(не особо) Дом";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonReset;
        private Button buttonAlarm;
        private Panel pnlWindow;
        private Panel pnlDoor;
    }
}
