namespace MarsRover
{
    using System.Drawing;

    /// <summary>Represents an interface for a perfectly square Plateu.</summary>
    public interface IPlateu
    {
        /// <summary>Gets or sets the x.</summary>
        /// <value>The x.</value>
        int X { get; set; }

        /// <summary>Gets or sets the y.</summary>
        /// <value>The y.</value>
        int Y { get; set; }

        /// <summary>Gets or sets the size.</summary>
        /// <value>The size.</value>
        int Size { get; set; }

        /// <summary>Gets or sets the color.</summary>
        /// <value>The color.</value>
        Color Color { get; set; }
    }
}
