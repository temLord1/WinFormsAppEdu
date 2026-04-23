using System.Xml.Serialization;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsAppEdu
{
    public partial class Form1 : Form
    {
        private Color topColor = Color.Red;
        private Color midColor = Color.Yellow;
        private Color bottomColor = Color.Green;

        private int greenDuration = 5;

        private Timer trafficTimer = new Timer();
        private int step = 0;
        private Timer countdownTimer = new Timer();
        private int secondsLeft = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Светофор";
            this.DoubleBuffered = true;
            this.Size = new Size(450, 450);
            this.Paint += TrafficLight_Paint;
            trafficTimer.Tick += TrafficTimer_Tick;
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += СountdownTimer_Tick;

            SetRed();
        }

        private void TrafficLight_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Фон
            e.Graphics.FillRectangle(Brushes.LightSteelBlue, 0, 0, this.Width, 250);
            e.Graphics.FillRectangle(Brushes.ForestGreen, 0, 250, this.Width, this.Height - 250);

            // Светофор
            e.Graphics.FillRectangle(Brushes.DarkGray, 110, 310, 25, 130);
            e.Graphics.FillRectangle(Brushes.DarkGray, 55, 30, 135, 285);

            // Лампы
            e.Graphics.FillEllipse(new SolidBrush(topColor), 82, 50, 80, 80);
            e.Graphics.FillEllipse(new SolidBrush(midColor), 82, 135, 80, 80);
            e.Graphics.FillEllipse(new SolidBrush(bottomColor), 82, 220, 80, 80);

            // Обратный отсчёт
            if (step == 3 && secondsLeft > 0)
            {
                using (Font countFont = new Font("Arial", 40, FontStyle.Bold))
                {
                    string text = secondsLeft.ToString();
                    SizeF textSize = e.Graphics.MeasureString(text, countFont);

                    float textX = 122 - (textSize.Width / 2);
                    float textY = 175 - (textSize.Height / 2);

                    using (SolidBrush fontBrush = new SolidBrush(bottomColor))
                    {
                        e.Graphics.DrawString(text, countFont, fontBrush, textX, textY);
                    }
                }
            }
        }

        private void UpdateTrafficLight()
        {
            trafficTimer.Stop();
            step++;

            switch (step)
            {
                case 1:
                    SetRed();
                    trafficTimer.Interval = 2000;
                    trafficTimer.Start();
                    break;

                case 2:
                    SetReady();
                    trafficTimer.Interval = 2000;
                    trafficTimer.Start();
                    break;

                case 3:
                    SetGreen();
                    secondsLeft = greenDuration;
                    countdownTimer.Start();
                    trafficTimer.Interval = greenDuration * 1000;
                    trafficTimer.Start();
                    break;

                case 4:
                    countdownTimer.Stop();
                    secondsLeft = 0;
                    SetRed();
                    step = 0;
                    break;
            }
        }

        private void SetRed()
        {
            topColor = Color.Red;
            midColor = Color.Gray;
            bottomColor = Color.Gray;
            this.Invalidate();
        }

        private void SetReady()
        {
            topColor = Color.Red;
            midColor = Color.Yellow;
            bottomColor = Color.Gray;
            this.Invalidate();
        }

        private void SetGreen()
        {
            topColor = Color.Gray;
            midColor = Color.Gray;
            bottomColor = Color.Lime;
            this.Invalidate();
        }
        private void TrafficTimer_Tick(object? sender, EventArgs e)
        {
            UpdateTrafficLight();
        }

        private void СountdownTimer_Tick(object? sender, EventArgs e)
        {
            if (secondsLeft > 0)
            {
                secondsLeft--;
                this.Invalidate();
            }
            else
            {
                countdownTimer.Stop();
            }
        }

        private void buttonCrossTheRoad_Click(object sender, EventArgs e)
        {
            if (!trafficTimer.Enabled) UpdateTrafficLight();
        }
    }
}
