namespace WinFormsAppEdu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBoxLeft = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBoxRight = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(307, 136);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(810, 27);
            label2.Name = "label2";
            label2.Size = new Size(253, 136);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(477, 163);
            label3.Name = "label3";
            label3.Size = new Size(127, 26);
            label3.TabIndex = 2;
            label3.Text = "СПРАВКА";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // richTextBoxLeft
            // 
            richTextBoxLeft.BackColor = SystemColors.Control;
            richTextBoxLeft.BorderStyle = BorderStyle.None;
            richTextBoxLeft.Dock = DockStyle.Fill;
            richTextBoxLeft.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxLeft.Location = new Point(3, 3);
            richTextBoxLeft.Name = "richTextBoxLeft";
            richTextBoxLeft.ReadOnly = true;
            richTextBoxLeft.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxLeft.Size = new Size(509, 213);
            richTextBoxLeft.TabIndex = 3;
            richTextBoxLeft.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(richTextBoxRight, 1, 0);
            tableLayoutPanel1.Controls.Add(richTextBoxLeft, 0, 0);
            tableLayoutPanel1.Location = new Point(33, 207);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1030, 219);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // richTextBoxRight
            // 
            richTextBoxRight.BackColor = SystemColors.Control;
            richTextBoxRight.BorderStyle = BorderStyle.None;
            richTextBoxRight.Dock = DockStyle.Fill;
            richTextBoxRight.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxRight.Location = new Point(518, 3);
            richTextBoxRight.Name = "richTextBoxRight";
            richTextBoxRight.ReadOnly = true;
            richTextBoxRight.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxRight.Size = new Size(509, 213);
            richTextBoxRight.TabIndex = 4;
            richTextBoxRight.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Seal_Trasparent;
            pictureBox1.Location = new Point(33, 432);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(689, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.Logo_MAGTU;
            pictureBox2.Location = new Point(346, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(405, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 662);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBoxLeft;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBoxRight;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}