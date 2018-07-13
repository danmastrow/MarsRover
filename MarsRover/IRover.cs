namespace MarsRover
{
    using System.Drawing;
    public interface IRover
    {
        void Rotate(RelativeRotation rotation);
        void Move(int distance);
        IPath Path { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int Size { get; set; }
        Color Color { get; set; }
        CardinalDirection Direction { get; set; }
        Color DirectionColor { get; set; }
        Font DirectionFont { get; set; }
    }
}