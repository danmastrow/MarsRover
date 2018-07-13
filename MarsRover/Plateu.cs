namespace MarsRover
{
    using System.Drawing;

    public class Plateu : IPlateu
    {
        public Plateu(int x, int y, int size, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            this.Color = color;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; }
    }
}