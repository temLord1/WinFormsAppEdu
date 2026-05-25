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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv1 = new DataGridView();
            panel1 = new Panel();
            tb3 = new TextBox();
            tb2 = new TextBox();
            tb1 = new TextBox();
            label1 = new Label();
            cmb1 = new ComboBox();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv1.DefaultCellStyle = dataGridViewCellStyle1;
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
            panel1.Controls.Add(tb3);
            panel1.Controls.Add(tb2);
            panel1.Controls.Add(tb1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmb1);
            panel1.Location = new Point(0, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 101);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // tb3
            // 
            tb3.Location = new Point(145, 66);
            tb3.Name = "tb3";
            tb3.ReadOnly = true;
            tb3.Size = new Size(167, 23);
            tb3.TabIndex = 4;
            // 
            // tb2
            // 
            tb2.Location = new Point(145, 37);
            tb2.Name = "tb2";
            tb2.ReadOnly = true;
            tb2.Size = new Size(167, 23);
            tb2.TabIndex = 3;
            // 
            // tb1
            // 
            tb1.Location = new Point(145, 8);
            tb1.Name = "tb1";
            tb1.ReadOnly = true;
            tb1.Size = new Size(167, 23);
            tb1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Выбор столбца";
            // 
            // cmb1
            // 
            cmb1.FormattingEnabled = true;
            cmb1.Location = new Point(8, 26);
            cmb1.Name = "cmb1";
            cmb1.Size = new Size(121, 23);
            cmb1.TabIndex = 0;
            cmb1.SelectedIndexChanged += cmb1_SelectedIndexChanged;
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
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv1;
        private Panel panel1;
        private Label label1;
        private ComboBox cmb1;
        private TextBox tb3;
        private TextBox tb2;
        private TextBox tb1;
    }
}
