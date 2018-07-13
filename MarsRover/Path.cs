using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class RoverPath : IPath
    {
        private IList<RoverMove> roverControl;
        private int currentMove;

        public RoverPath(string unparsedPath, int startingMove)
        {
            this.roverControl = ParsePath(unparsedPath);
            this.currentMove = startingMove;
        }

        public RoverPath(IList<RoverMove> roverControl, int startingMove)
        {
            this.roverControl = roverControl;
            this.currentMove = startingMove;
        }

        public bool CanMoveNext()
        {
            return (this.currentMove < roverControl.Count);
        }

        public void MoveNext()
        {
            currentMove++;
        }

        public void Reset()
        {
            this.currentMove = 0;
        }
        private IList<RoverMove> ParsePath(string unparsedPath)
        {
            var result = new List<RoverMove>();
            var seperatedPath = unparsedPath.Trim().ToCharArray().ToList();

            return seperatedPath.Select(f => (RoverMove)Enum.Parse(typeof(RoverMove), f.ToString())).ToList();
        }

        public RoverMove CurrentMove
        {
            get
            {
                return roverControl[currentMove];
            }
        }
    }
}
