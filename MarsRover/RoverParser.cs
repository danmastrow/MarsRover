using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverParser : IRoverParser
    {
        /// <summary>
        /// Parses the rovers.
        /// Odd number is rover starting position
        /// Even number is rover path
        /// First character of odd line is x, second is y, third is cardinal direction
        /// Even line is path.
        /// </summary>
        /// <param name="parsedFile">The parsed file.</param>
        /// <param name="startingNode">The starting node.</param>
        /// <param name="size">The size.</param>
        /// <param name="startingX">The starting x.</param>
        /// <param name="startingY">The starting y.</param>
        /// <param name="graphicsScale">The graphics scale.</param>
        /// <param name="roverColor">Color of the rover.</param>
        /// <param name="directionColor">Color of the direction.</param>
        /// <param name="directionFont">The direction font.</param>
        /// <returns>IList of Rovers.</returns>
        public IList<IRover> ParseRovers(IList<string> parsedFile, int startingNode, int size, int startingX, int startingY, int graphicsScale, Color roverColor, Color directionColor, Font directionFont)
        {
            IList<IRover> rovers = new List<IRover>();

            for (int i = 1; i < parsedFile.Count; i += 2)
            {
                var startingPosition = parsedFile[i].Split(' ');
                var x = Int32.Parse(startingPosition[0].Trim()) * graphicsScale;
                var y = Int32.Parse(startingPosition[1].Trim()) * graphicsScale;
                var direction = (CardinalDirection)Enum.Parse(typeof(CardinalDirection), startingPosition[2]);

                IPath path = new RoverPath(parsedFile[i + 1], startingNode);
                IRover rover = new Rover(x + startingX, y + startingY,
                            size * graphicsScale, roverColor, direction, directionColor, directionFont);
                rover.Path = path;
                rovers.Add(rover);
            }

            return rovers;
        }
    }
}
