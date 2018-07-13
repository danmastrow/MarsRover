namespace MarsRover
{
    public class Plateu : IPlateu
    {
        public Plateu(int size)
        {
            this.Size = size;
        }
        public int Size { get; set; }
    }
}