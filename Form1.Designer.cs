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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgv1 = new DataGridView();
            panel1 = new Panel();
            btn1 = new Button();
            tb1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToResizeColumns = false;
            dgv1.AllowUserToResizeRows = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.BorderStyle = BorderStyle.None;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            dgv1.Dock = DockStyle.Fill;
            dgv1.Location = new Point(0, 0);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersVisible = false;
            dgv1.ScrollBars = ScrollBars.None;
            dgv1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv1.Size = new Size(580, 357);
            dgv1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(tb1);
            panel1.Location = new Point(267, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 64);
            panel1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(225, 8);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 47);
            btn1.TabIndex = 3;
            btn1.Text = "Новый массив";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(11, 8);
            tb1.Multiline = true;
            tb1.Name = "tb1";
            tb1.ReadOnly = true;
            tb1.Size = new Size(202, 47);
            tb1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(580, 357);
            Controls.Add(panel1);
            Controls.Add(dgv1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "I JUST MADE SOME BULLSHI";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv1;
        private Panel panel1;
        private TextBox tb1;
        private Button btn1;
    }
}
