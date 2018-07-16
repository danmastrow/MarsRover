namespace MarsRover
{
    using System.Collections.Generic;
    using System.Drawing;

    public interface IRoverParser
    {
        IList<IRover> ParseRovers(IList<string> parsedFile, int startingNode, int size, int startingX, int startingY, int graphicsScale, Color roverColor, Color directionColor, Font directionFont);
    }
}
