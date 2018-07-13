using System;
using System.Drawing;

namespace MarsRover
{
    public class Rover : IRover
    {
        /// <summary>Initializes a new instance of the <see cref="Rover"/> class.</summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="size">The size.</param>
        /// <param name="color">The color.</param>
        /// <param name="direction">The direction.</param>
        /// <param name="directionColor">Color of the direction.</param>
        /// <param name="directionFont">The direction font.</param>
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

        /// <summary>Moves to the next node in the path depending on the CurrentMove.</summary>
        public void Move()
        {
            if (Path == null)
                throw new Exception("Path cannot be null when moving.");
            MoveNext();
            if (Path.CanMoveNext())
                Path.MoveNext();
        }

        private void MoveNext()
        {
            if (Path.CanMoveNext())
            {
                switch (Path.CurrentMove)
                {
                    case RoverMove.L:
                        // Change CardinalDirection anti clockwise.
                        RotateLeft();
                        break;
                    case RoverMove.R:
                        // Change CardinalDirection clockwise.
                        RotateRight();
                        break;
                    case RoverMove.M:
                        MoveForward();
                        break;
                    default:
                        break;
                }

            }
        }

        private void MoveForward()
        {
            // Depending on the direction faced move appropriately.
            switch (Direction)
            {
                case CardinalDirection.N:
                    this.Y -= Size;

                    break;
                case CardinalDirection.E:
                    this.X += Size;

                    break;
                case CardinalDirection.S:
                    this.Y += Size;
                    break;
                case CardinalDirection.W:
                    this.X -= Size;
                    break;
                default:
                    throw new Exception("An unhandled CardinalDirection has been added.");
            }
        }

        public void RotateRight()
        {
            switch (Direction)
            {
                case CardinalDirection.N:
                    this.Direction = CardinalDirection.E;
                    break;
                case CardinalDirection.E:
                    this.Direction = CardinalDirection.S;
                    break;
                case CardinalDirection.S:
                    this.Direction = CardinalDirection.W;
                    break;
                case CardinalDirection.W:
                    this.Direction = CardinalDirection.N;
                    break;
                default:
                    throw new Exception("An unhandled CardinalDirection has been added.");
            }
        }

        public void RotateLeft()
        {
            switch (Direction)
            {
                case CardinalDirection.N:
                    this.Direction = CardinalDirection.W;
                    break;
                case CardinalDirection.E:
                    this.Direction = CardinalDirection.N;
                    break;
                case CardinalDirection.S:
                    this.Direction = CardinalDirection.E;
                    break;
                case CardinalDirection.W:
                    this.Direction = CardinalDirection.S;
                    break;
                default:
                    throw new Exception("An unhandled CardinalDirection has been added.");
            }
        }

        /// <summary>Gets the point.</summary>
        /// <value>The point.</value>
        public Point Point { get { return new Point(X, Y); } }

        /// <summary>Gets or sets the path.</summary>
        /// <value>The path.</value>
        public IPath Path { get; set; }

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

        /// <summary>Gets or sets the direction.</summary>
        /// <value>The direction.</value>
        public CardinalDirection Direction { get; set; }

        /// <summary>Gets or sets the color of the direction.</summary>
        /// <value>The color of the direction.</value>
        public Color DirectionColor { get; set; }

        /// <summary>Gets or sets the direction font.</summary>
        /// <value>The direction font.</value>
        public Font DirectionFont { get; set; }
    }
}
