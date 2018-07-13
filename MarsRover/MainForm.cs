namespace MarsRover
{
    using System.Drawing;
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;

    public partial class MainForm : Form
    {
        private readonly int graphicsMultiplier = 100;
        private readonly int animationInterval = 50;
        private IList<IRover> testRovers;
        private IPlateu plateu;
        private Timer animationTimer;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. Read and seperate File
            Console.WriteLine("Parsing file");
            // TODO: Implement parsing of file.

            // 2. Parse size of the plateu.
            var testPlateuSize = 5 * graphicsMultiplier;
            plateu = new Plateu(100, 100, testPlateuSize, Color.Orange);
            // 3. Parse Rovers
            string[] testRoverInput = { "1 2 N", "3 E" };
            testRovers = new List<IRover>()
            {
                new Rover(50, 50, 50, Color.Red, CardinalDirection.North, Color.Black, new Font("Arial",12)),
                new Rover(400, 400, 50, Color.Red, CardinalDirection.West, Color.Black, new Font("Arial",12))
            };

            // 4. Parse each Rovers Path
            string[] paths = { "LMLMLMLMM 3", "MMRMMRMRRM" };

            // 5. Start animation timer.
            InitializeTimer(animationInterval);
        }

        private void AnimationTick(object Sender, EventArgs e)
        {
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
            foreach (var rover in testRovers)
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

    }
}
