namespace MarsRover
{
    using System.Drawing;

    /// <summary>Represents the squared Plateu.</summary>
    /// <seealso cref="MarsRover.IPlateau" />
    public class Plateau : IPlateau
    {
        /// <summary>Initializes a new instance of the <see cref="Plateau"/> class.</summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="size">The size.</param>
        /// <param name="color">The color.</param>
        public Plateau(int x, int y, int size, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            this.Color = color;
        }

        /// <summary>Gets or sets the x.</summary>
        /// <value>The x.</value>
        public int X { get; set; }

        /// <summary>Gets or sets the y.</summary>
        /// <value>The y.</value>
        public int Y { get; set; }

        /// <summary>Gets or sets the size.</summary>
        /// <value>The size.</value>
        public int Size { get; set; }

        /// <summary>Gets or sets the color.</summary>
        /// <value>The color.</value>
        public Color Color { get; set; }
    }
}