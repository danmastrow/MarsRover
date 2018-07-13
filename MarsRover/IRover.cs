namespace MarsRover
{
    using System.Drawing;

    /// <summary>An interface for a Rover.</summary>
    public interface IRover
    {
        /// <summary>Moves the specified distance.</summary>
        /// <param name="distance">The distance.</param>
        void Move(int distance);

        /// <summary>Gets or sets the path.</summary>
        /// <value>The path.</value>
        IPath Path { get; set; }

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

        /// <summary>Gets or sets the direction.</summary>
        /// <value>The direction.</value>
        CardinalDirection Direction { get; set; }

        /// <summary>Gets or sets the color of the direction.</summary>
        /// <value>The color of the direction.</value>
        Color DirectionColor { get; set; }

        /// <summary>Gets or sets the direction font.</summary>
        /// <value>The direction font.</value>
        Font DirectionFont { get; set; }
    }
}