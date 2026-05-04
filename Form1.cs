using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {
        private bool isLightsOn = false;
        private bool isDoorOpen = false;
        private bool isTriggered = false;
        private bool isAlarmed = false;
        private bool tickState = false;
        private Timer alarmTimer;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
            alarmTimer = new Timer();
            alarmTimer.Interval = 400;
            alarmTimer.Tick += AlarmTimer_Tick;
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int houseX = 225;
            int houseY = 300;
            int houseWidth = 350;
            int houseHeight = 220;

            //Основная стена
            using (var wallBrush = new SolidBrush(Color.LightGoldenrodYellow))
            {
                e.Graphics.FillRectangle(wallBrush, houseX, houseY, houseWidth, houseHeight);
            }

            int roofLeft = houseX - 20;
            int roofRight = houseX + houseWidth + 20;
            int roofTop = houseY;
            int roofPeak = houseY - 120;
            int roofPeakX = houseX + houseWidth / 2;

            // Крыша (через путь)
            using (var roofBrush = new SolidBrush(Color.Firebrick))
            {
                using (var path = new GraphicsPath())
                {
                    path.AddLine(roofLeft, roofTop, roofPeakX, roofPeak);
                    path.AddLine(roofPeakX, roofPeak, roofRight, roofTop);
                    path.AddLine(roofRight, roofTop, roofLeft, roofTop);
                    e.Graphics.FillPath(roofBrush, path);
                }
            }

            // Дымоход
            using (SolidBrush chimneyBrush = new SolidBrush(Color.SaddleBrown))
            {
                e.Graphics.FillRectangle(chimneyBrush, houseX + 220, houseY - 130, 30, 90);
            }

            // Сигнализация
            int alarmSize = 20;
            int alarmX = pnlDoor.Location.X + (pnlDoor.Width / 2) - (alarmSize / 2);
            int alarmY = pnlDoor.Location.Y - 30;
            Color alarmColor;

            if (isTriggered)
            {
                alarmColor = tickState ? Color.Red : Color.OrangeRed;
            }
            else
            {
                alarmColor = isAlarmed ? Color.DarkRed : Color.Gray;
            }

            using (SolidBrush alarmBrush = new SolidBrush(alarmColor))
            {
                e.Graphics.FillEllipse(alarmBrush, alarmX, alarmY, alarmSize, alarmSize);
            }
        }

        // Крестовина Окна
        private void pnlWindow_Paint(object? sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                int w = pnlWindow.Width;
                int h = pnlWindow.Height;

                e.Graphics.DrawLine(pen, 0, h / 2, w, h / 2);
                e.Graphics.DrawLine(pen, w / 2, 0, w / 2, h);
                e.Graphics.DrawRectangle(pen, 0, 0, w - 1, h - 1);
            }
        }

        // Ручка Двери
        private void pnlDoor_Paint(object? sender, PaintEventArgs e)
        {
            Color handleColor = isDoorOpen ? pnlDoor.BackColor : Color.Gold;
            using (SolidBrush handleBrush = new SolidBrush(handleColor))
            {
                int handleSize = 8;
                e.Graphics.FillEllipse(handleBrush, pnlDoor.Width - 15, pnlDoor.Height / 2, handleSize, handleSize);
            }
        }

        private void SecurityZone_Click(object sender, EventArgs e)
        {
            if (isAlarmed)
            {
                isTriggered = true;
                alarmTimer.Start();
            }
        }

        private void Window_Click(object sender, EventArgs e)
        {
            if (!isAlarmed)
            {
                pnlWindow.BackColor = isLightsOn ? Color.Yellow : Color.LightSkyBlue;
                isLightsOn = !isLightsOn;
                this.Invalidate();
            }
        }

        private void Door_Click(object sender, EventArgs e)
        {
            if (!isAlarmed)
            {
                isDoorOpen = !isDoorOpen;
                pnlDoor.BackColor = isDoorOpen ? Color.DarkGray : Color.SaddleBrown;
                this.Invalidate();
            }
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            isAlarmed = !isAlarmed;
            isDoorOpen = false;
            pnlDoor.BackColor = Color.SaddleBrown;

            if (!isAlarmed)
            {
                isTriggered = false;
                alarmTimer.Stop();
            }
            this.Invalidate();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            isAlarmed = false;
            isTriggered = false;
            isLightsOn = false;
            isDoorOpen = false;
            pnlWindow.BackColor = Color.LightSkyBlue;
            pnlDoor.BackColor = Color.SaddleBrown;
            alarmTimer.Stop();
            this.Invalidate();
        }

        private void AlarmTimer_Tick(object? sender, EventArgs e)
        {
            tickState = !tickState;
            this.Invalidate();
        }
    }
}
