namespace MarsRover
{
    public interface IPath
    {
        bool CanMoveNext();
        void MoveNext();
        void Reset();
        RoverMove CurrentMove { get; }
    }
}
