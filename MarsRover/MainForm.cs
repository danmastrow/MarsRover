namespace MarsRover
{
    using System.Drawing;
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public partial class MainForm : Form
    {
        private readonly int graphicsMultiplier = 100;
        private readonly int animationInterval = 50;
        private IList<IRover> rovers;
        private IPlateu plateu;
        private IList<IPath> paths;
        private Timer animationTimer;


        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IPlateu plateu, IList<IRover> rovers)
        {
            this.plateu = plateu;
            this.rovers = rovers;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AnimationTick(object Sender, EventArgs e)
        {
            foreach (var rover in rovers)
            {
                rover.Move(5);
            }

            RefreshGraphics();
            DrawPlateu();
            DrawRovers();
        }

        private void DrawPlateu()
        {
            Graphics formGraphics = this.CreateGraphics();
            var brush = new SolidBrush(plateu.Color);
            var rect = new Rectangle(plateu.X, plateu.Y, plateu.Size, plateu.Size);
            formGraphics.FillRectangle(brush, rect);
        }

        private void DrawRovers()
        {
            Graphics formGraphics = this.CreateGraphics();
            foreach (var rover in rovers)
            {
                var rectBrush = new SolidBrush(rover.Color);
                var stringBrush = new SolidBrush(rover.DirectionColor);
                var rect = new Rectangle(rover.X, rover.Y, rover.Size, rover.Size);

                formGraphics.FillRectangle(rectBrush, rect);
                formGraphics.DrawString(rover.Direction.ToString(), rover.DirectionFont, stringBrush, rover.X, rover.Y);

                rectBrush.Dispose();
                stringBrush.Dispose();
            }
            formGraphics.Dispose();
        }

        private void InitializeTimer(int interval)
        {
            animationTimer = new Timer();
            animationTimer.Interval = interval;
            animationTimer.Tick += AnimationTick;
            animationTimer.Enabled = true;
        }

        private void RefreshGraphics()
        {
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.White);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InitializeTimer(animationInterval);
        }
    }
}
