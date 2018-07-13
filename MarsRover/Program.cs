namespace MarsRover
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    static class Program
    {
        private static int plateuInitialX = 0;
        private static int plateuInitialY = 0;
        private static int roverStartingMove = 0;
        private static int graphicsScale = 10;
        private static int roverSize = 1;
        private static Color plateuColor = Color.Orange;
        private static Color roverColor = Color.OrangeRed;
        private static Color roverTextColor = Color.Black;
        private static Font roverFont = new Font("Arial", 12);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Read file
            var parsedFile = FileManager.ReadFile("./testfiles/test.txt");

            // TODO: Implement further parsed file validation before parsing.
            if (parsedFile.Count < 3 || parsedFile.Count % 2 == 0)
                throw new Exception("InvalidFile - File must have an odd number of lines greater than or equal to 3.");

            // 2. Parse Plateu
            IPlateu plateu = ParsePlateu(parsedFile);

            // 3. Parse Rover and Paths
            var rovers = ParseRovers(parsedFile);

            // 4. Instantiate form with the parsed data.
            var mainForm = new MainForm(plateu, rovers);

            Application.Run(mainForm);
        }

        private static IPlateu ParsePlateu(IList<string> parsedFile)
        {
            var plateuSizes = parsedFile[0].Split(' ');

            if (plateuSizes.Length > 3 || plateuSizes[0] != plateuSizes[1])
                throw new Exception("InvalidFile - Plateu must have two values that are the same.");

            var plateuSize = Int32.Parse(plateuSizes[0]) * graphicsScale;

            IPlateu plateu = new Plateu(plateuInitialX * graphicsScale, plateuInitialY * graphicsScale, plateuSize, plateuColor);
            return plateu;
        }

        private static IList<IRover> ParseRovers(IList<string> parsedFile)
        {
            IList<IRover> rovers = new List<IRover>();

            for (int i = 1; i < parsedFile.Count; i += 2)
            {
                // Odd number is rover starting position
                // Even number is rover path
                // First character of odd line is x, second is y, third is cardinal direction
                // Even line is path.

                var startingPosition = parsedFile[i].Split(' ');
                var x = Int32.Parse(startingPosition[0].Trim()) * graphicsScale;
                var y = Int32.Parse(startingPosition[1].Trim()) * graphicsScale;
                var direction = (CardinalDirection)Enum.Parse(typeof(CardinalDirection), startingPosition[2]);

                IPath path = new RoverPath(parsedFile[i + 1], roverStartingMove);
                IRover rover = new Rover(x, y, roverSize * graphicsScale, roverColor, direction, roverTextColor, roverFont);
                rover.Path = path;
                rovers.Add(rover);
            }

            return rovers;
        }
    }
}
