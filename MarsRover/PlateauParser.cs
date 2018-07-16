using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class PlateauParser : IPlateauParser
    {
        public IPlateau ParsePlateau(IList<string> parsedFile, int startingX, int startingY, int graphicsScale, Color color)
        {
            var plateuSizes = parsedFile[0].Split(' ');

            if (plateuSizes.Length > 3 || plateuSizes[0] != plateuSizes[1])
                throw new Exception("InvalidFile - Plateu must have two values that are the same.");

            var size = Int32.Parse(plateuSizes[0]) * graphicsScale;

            IPlateau plateu = new Plateau(startingX, startingY, size, color);
            return plateu;
        }
    }
}
