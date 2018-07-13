namespace MarsRover
{
    using System.Drawing;

    public interface IPlateu
    {
        int Size { get; set; }
        int X { get; set; }
        int Y { get; set; }
        Color Color { get; set; }
    }
}
