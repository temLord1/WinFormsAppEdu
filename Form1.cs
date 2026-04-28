using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {
        private int colorStep = 0;
        private int blinkStep = 0;
        private Timer timerColor = new Timer();
        private Timer timerBlink = new Timer();

        public Form1()
        {
            InitializeComponent();
            InitCircles();
            InitTimers();
        }

        private void InitCircles()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, panel1.Width, panel1.Height);
            Region roundRegion = new Region(path);

            panel1.Region = roundRegion;
            panel1.BackColor = Color.White;
            panel1.Visible = true;

            panel2.Region = roundRegion;
            panel2.BackColor = Color.White;
            panel2.Visible = true;

            panel3.Region = roundRegion;
            panel3.BackColor = Color.White;
            panel3.Visible = true;

            panel4.Region = roundRegion;
            panel4.BackColor = Color.White;
            panel4.Visible = true;
        }

        private void InitTimers()
        {
            timerColor.Interval = 500;
            timerColor.Tick += TimerColor_Tick;

            timerBlink.Interval = 300 ;
            timerBlink.Tick += TimerBlink_Tick;
        }

        private void TimerColor_Tick(object? sender, EventArgs e)
        {
            UpdateColorAnimation();
        }
        private void TimerBlink_Tick(object? sender, EventArgs e)
        {
            UpdateBlinkAnimation();
        }

        private void UpdateColorAnimation()
        {
            colorStep++;
            if (colorStep == 1) panel1.BackColor = Color.Red;
            else if (colorStep == 2) panel2.BackColor = Color.Green;
            else if (colorStep == 3) panel3.BackColor = Color.Yellow;
            else if (colorStep == 4)
            {
                panel4.BackColor = Color.Blue;
                timerColor.Stop();
            }
        }

        private void UpdateBlinkAnimation()
        {
            blinkStep++;
            if (blinkStep == 1) panel1.Visible = false;
            else if (blinkStep == 2) { panel1.Visible = true; panel2.Visible = false; }
            else if (blinkStep == 3) { panel2.Visible = true; panel3.Visible = false; }
            else if (blinkStep == 4) { panel3.Visible = true; panel4.Visible = false; }
            else if (blinkStep == 5)
            {
                panel4.Visible = true;
                blinkStep = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerColor.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerBlink.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerColor.Stop();
            timerBlink.Stop();
            colorStep = 0;
            blinkStep = 0;

            panel1.BackColor = panel2.BackColor = panel3.BackColor = panel4.BackColor = Color.White;
            panel1.Visible = panel2.Visible = panel3.Visible = panel4.Visible = true;
        }
    }
}
