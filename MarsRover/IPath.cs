namespace MarsRover
{
    public interface IPath
    {
        void MoveNext();
        void Reset();
        RoverMove CurrentMove { get; }
        RoverMove FinalMove { get; }
    }
}
