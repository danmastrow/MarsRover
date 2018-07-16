namespace MarsRover
{
    using System.Collections.Generic;
    using System.Drawing;
    public interface IPlateauParser
    {
        IPlateau ParsePlateau(IList<string> parsedFile, int startingX, int startingY, int graphicsScale, Color color);

    }
}
