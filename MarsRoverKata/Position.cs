namespace MarsRoverKata
{
    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; } // rows
        public int Y { get; } // columns
    }
}