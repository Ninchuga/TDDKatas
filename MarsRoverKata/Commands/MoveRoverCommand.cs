namespace MarsRoverKata.Commands
{
    public abstract class MoveRoverCommand
    {
        public abstract Position Execute(Position currentRoverPosition, Directions currentRoverDirection);
    }
}
