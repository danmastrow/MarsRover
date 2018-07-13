using System;
using System.Drawing;

namespace MarsRover
{
    public class Rover : IRover
    {
        public enum RoverControl
        {
            L,
            R,
            M
        }

        public Rover(int x, int y, int size, Color color, CardinalDirection direction, Color directionColor, Font directionFont)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            this.Color = color;
            this.Direction = direction;
            this.DirectionColor = directionColor;
            this.DirectionFont = directionFont;
        }

        public void Rotate(RelativeRotation rotation)
        {
            throw new NotImplementedException();
        }

        public Point Point { get { return new Point(X, Y); } }
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; }
        public CardinalDirection Direction { get; set; }
        public Color DirectionColor { get; set; }
        public Font DirectionFont { get; set; }
    }
}
