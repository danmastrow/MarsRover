namespace MarsRover
{
    using System.Drawing;
    public interface IRover
    {
        int X { get; set; }
        int Y { get; set; }
        int Size { get; set; }
        Color Color { get; set; }
        CardinalDirection Direction { get; set; }
        Color DirectionColor { get; set; }
        Font DirectionFont { get; set; }

        void Rotate(RelativeRotation rotation);
    }
}