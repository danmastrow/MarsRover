namespace MarsRover
{
    using System.Drawing;
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;

    public partial class MainForm : Form
    {
        private IList<IRover> rovers;
        private IPlateau plateau;
        private IPlateauParser plateauParser;
        private IRoverParser roverParser;
        private Timer animationTimer;

        private static string invalidFile = "A valid file must be provided before starting";
        private static int roverStartingMove = 0;
        private static int roverSize = 1;
        private Color plateauColor = Color.Orange;
        private Color roverColor = Color.OrangeRed;
        private Color roverDirectionColor = Color.Black;
        private static Font roverDirectionFont = new Font("Arial", 12);


        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(IPlateauParser plateauParser, IRoverParser roverParser)
        {
            this.plateauParser = plateauParser;
            this.roverParser = roverParser;
            InitializeComponent();
        }

        /// <summary>Handles the Load event of the MainForm control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.openInputFileDialog.CheckFileExists = true;
        }

        /// <summary>Refreshes the graphics and draws the animation to the screen.</summary>
        /// <param name="Sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void AnimationTick(object Sender, EventArgs e)
        {
            foreach (var rover in rovers)
            {
                rover.Move();
            }

            ResetCanvas();
            DrawPlateau();
            DrawRovers();
        }

        /// <summary>Draws the plateau.</summary>
        private void DrawPlateau()
        {
            Graphics formGraphics = this.CreateGraphics();
            var brush = new SolidBrush(plateau.Color);
            var rect = new Rectangle(plateau.X, plateau.Y, plateau.Size, plateau.Size);
            formGraphics.FillRectangle(brush, rect);
        }

        /// <summary>Draws the rovers.</summary>
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

        /// <summary>Initializes the timer.</summary>
        /// <param name="tickInterval">The interval to tick.</param>
        private void InitializeTimer(int tickInterval)
        {
            animationTimer = new Timer();
            animationTimer.Interval = tickInterval;
            animationTimer.Tick += AnimationTick;
            animationTimer.Enabled = true;
        }

        /// <summary>Clears the form.</summary>
        private void ResetCanvas()
        {
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.White);
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                var file = this.openInputFileDialog.ShowDialog();

                // 1. Read file
                var readFile = FileManager.ReadFile(this.openInputFileDialog.FileName);

                // TODO: Implement further parsed file validation before parsing.
                if (readFile.Count < 3 || readFile.Count % 2 == 0)
                    throw new Exception("InvalidFile - File must have an odd number of lines greater than or equal to 3.");

                // 2. Parse Plateu and Rovers
                var startingX = this.Width / 2;
                var startingY = this.Height / 2;
                var gScale = (int)this.graphicsScaleInput.Value;
                this.plateau = plateauParser.ParsePlateau(readFile, startingX, startingY, gScale, plateauColor);
                this.rovers = roverParser.ParseRovers(readFile, roverStartingMove, roverSize, startingX, startingY, gScale, roverColor, roverDirectionColor, roverDirectionFont);

                this.textBoxInputFile.Text = this.openInputFileDialog.FileName;
                //ResetCanvas();
            }
            catch (Exception ex)
            {
                this.errorText.Text = invalidFile;
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (rovers == null || rovers.Count == 0)
            {
                this.errorText.Text = invalidFile;
            }
            else
            {
                foreach (var rover in rovers)
                {
                    rover.Path.Reset();
                }
                InitializeTimer((int)animationSpeedInput.Value);
            }
        }

        private void animationSpeedInput_ValueChanged(object sender, EventArgs e)
        {
            animationTimer.Interval = (int)animationSpeedInput.Value;
        }

        private void buttonColors_Click(object sender, EventArgs e)
        {
            var result = roverColorDialog.ShowDialog();
            var result2 = roverDirectionColorDialog.ShowDialog();

            this.roverColor = roverColorDialog.Color;
            this.roverDirectionColor = roverDirectionColorDialog.Color;
        }
    }
}
